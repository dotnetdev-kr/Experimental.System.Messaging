# Experimental.System.Messaging

Experimental port of System.Messaging (for .NET Core)

[![NuGet Version](https://img.shields.io/nuget/v/Experimental.System.Messaging.svg)](https://www.nuget.org/packages/Experimental.System.Messaging)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Experimental.System.Messaging.svg)](https://www.nuget.org/packages/Experimental.System.Messaging)
[![Build](https://github.com/dotnetdev-kr/Experimental.System.Messaging/actions/workflows/build.yml/badge.svg)](https://github.com/dotnetdev-kr/Experimental.System.Messaging/actions/workflows/build.yml)
[![License](https://img.shields.io/badge/license-Ms--RL-blue.svg)](LICENSE.txt)

## Introduction

This package is an unofficial port of the .NET Framework System.Messaging assembly for .NET Core/.NET 8+ applications running on Windows. It is provided for development convenience. If Microsoft officially releases an MSMQ client package, you should migrate to the official package.

The source code for this package is derived from the .NET Framework reference source code.

## License Notice

This project is licensed under the **Microsoft Reciprocal License (Ms-RL)**.

The original source code was obtained from Microsoft Reference Source (referencesource.microsoft.com) when it was available under the Ms-RL license. Due to insufficient understanding at the time, this package was mistakenly distributed under the MIT License from its initial release until version 1.1.0. We sincerely apologize for this error and have corrected the license to Ms-RL starting from version 1.2.0.

As a derivative work based on Ms-RL licensed code, this package must also be distributed under Ms-RL in accordance with the license terms.

## Disclaimer

This source code is based on Microsoft's Reference Source, but may contain differences from the original. Bug fixes have been applied in the public interest based on community-reported issues. If Microsoft officially releases an MSMQ client package for .NET Core/.NET 5+, that official package should take priority over this experimental package. Users are encouraged to migrate to the official package when it becomes available.

## Queue Path Formats

The `MessageQueue` constructor accepts various path formats. Below are common formats you can use:

### Local Queue Paths

```csharp
// Local private queue
var queue = new MessageQueue(@".\Private$\MyQueue");

// Local private queue using machine name
var queue = new MessageQueue(@"MachineName\Private$\MyQueue");
```

### Remote Queue Paths (Format Names)

To connect to remote queues, use the direct format name syntax:

```csharp
// Using TCP (recommended for remote queues)
var queue = new MessageQueue(@"FormatName:Direct=TCP:192.168.1.100\Private$\MyQueue");

// Using OS (uses Windows networking)
var queue = new MessageQueue(@"FormatName:Direct=OS:RemoteMachineName\Private$\MyQueue");

// Using HTTP (requires MSMQ HTTP support)
var queue = new MessageQueue(@"FormatName:Direct=HTTP://hostname/msmq/Private$/MyQueue");

// Using HTTPS
var queue = new MessageQueue(@"FormatName:Direct=HTTPS://hostname/msmq/Private$/MyQueue");
```

### Format Name Syntax Reference

| Protocol | Format | Example |
|----------|--------|---------|
| TCP | `FormatName:Direct=TCP:address\queue` | `FormatName:Direct=TCP:192.168.1.100\Private$\MyQueue` |
| OS | `FormatName:Direct=OS:machine\queue` | `FormatName:Direct=OS:Server01\Private$\MyQueue` |
| HTTP | `FormatName:Direct=HTTP://host/msmq/queue` | `FormatName:Direct=HTTP://server/msmq/Private$/MyQueue` |
| HTTPS | `FormatName:Direct=HTTPS://host/msmq/queue` | `FormatName:Direct=HTTPS://server/msmq/Private$/MyQueue` |

### Public Queues

```csharp
// Local public queue
var queue = new MessageQueue(@"MachineName\MyPublicQueue");

// Remote public queue using format name
var queue = new MessageQueue(@"FormatName:Direct=TCP:192.168.1.100\MyPublicQueue");
```

### Important Notes

- When using TCP format, use the IP address or hostname directly after `TCP:` without brackets
- For private queues, always include `Private$` in the path
- Remote queue access requires appropriate firewall rules and MSMQ configuration on the remote machine
- The `Direct` format bypasses Active Directory lookup, making it suitable for workgroup environments

## Release Note

### v1.2.0 (2025-11-30)

- **Breaking Change**: Changed target framework from `netstandard2.0` to `net8.0`. Since MSMQ is a Windows-only technology, the original cross-platform targeting via .NET Standard was unnecessary. Mono has transitioned to WineHQ, .NET Framework already has native System.Messaging support, and other platforms (Silverlight, UWP, Unity) are not applicable targets for this library.
- **License Correction**: Changed license from MIT to Ms-RL (Microsoft Reciprocal License) to properly comply with the original Microsoft Reference Source license terms.
- **Documentation**: Revised terminology throughout the documentation. Replaced "counterfeit" with "unofficial port" to better reflect the legitimate nature of this community-maintained derivative work.
- **New Feature**: Added support for setting access control on queue. Ported `AccessControlEntry`, `AccessControlEntryType`, `AccessControlList`, `MessageQueueAccessControlEntry`, `MessageQueuePermission`, `MessageQueuePermissionAccess`, `MessageQueuePermissionEntry`, and `MessageQueuePermissionEntryCollection` classes. (PR #5, contributed by @j0hnth0m)
- **Bug Fix**: Fixed Unicode string null termination in `StringToBytes` method. This bug affected `MessageQueue.Label`, `MessageQueue.MulticastAddress`, `Message.Label`, `Message.AuthenticationProviderName`, and queue format name properties.

### v1.1.0 (2019-11-06)

- **Breaking Change**: Moved `Trustee` class namespace from `System.Messaging` to `Experimental.System.Messaging`.

### v1.0.0 (2018-01-06)

- **Initial Release**: Ported System.Messaging for .NET Core with minimal feature set. Excludes advanced features such as code access security, execute permissions, and Active Directory integration.
