# Experimental.System.Messaging
Experimental port of System.Messaging (for .NET Core)

[![Image](https://img.shields.io/nuget/v/Experimental.System.Messaging.svg)](https://www.nuget.org/packages/Experimental.System.Messaging)

## Introduction

This package is a counterfeit of the .NET Framework version System.Messaging assembly for .NET Core applications running on Windows Client and Windows Server. It is provided for development convenience. Do not use this package if Microsoft officially releases this package again. Also, once it is released, you should migrate the code to the new package.

The source code for this package is excerpted from the .NET Framework reference source code.

## Release Note

### v1.1.0 (2019-11-06)
Trustee class namespace was moved from System.Messaging to Experimental.System.Messaging. It could break your existing build process.

### v1.0.0 (2018-01-06)
This version of the System.Messaging package excludes all advanced features such as code access security, execute permissions, and Active Directory integration. I released the package keeping in mind the minimal use of Message Queuing communication facilities. Please confirm whether it is suitable for actual use through unit test and integration test.
