# Experimental.System.Messaging
Experimental port of System.Messaging (for .NET Core)

[![Image](https://img.shields.io/nuget/v/Experimental.System.Messaging.svg)](https://www.nuget.org/packages/Experimental.System.Messaging)

## Introduction

This package is a counterfeit of the .NET Framework version System.Messaging assembly for .NET Core applications running on Windows Client and Windows Server. It is provided for development convenience. Do not use this package if Microsoft officially releases this package again. Also, once it is released, you should migrate the code to the new package.

The source code for this package is excerpted from the .NET Framework reference source code.

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
Fixed Unicode string null termination in `StringToBytes` method. This bug affected `MessageQueue.Label`, `MessageQueue.MulticastAddress`, `Message.Label`, `Message.AuthenticationProviderName`, and queue format name properties, causing them not to persist correctly to MSMQ.

### v1.1.0 (2019-11-06)
Trustee class namespace was moved from System.Messaging to Experimental.System.Messaging. It could break your existing build process.

### v1.0.0 (2018-01-06)
This version of the System.Messaging package excludes all advanced features such as code access security, execute permissions, and Active Directory integration. I released the package keeping in mind the minimal use of Message Queuing communication facilities. Please confirm whether it is suitable for actual use through unit test and integration test.
