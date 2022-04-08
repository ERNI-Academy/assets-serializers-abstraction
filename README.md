# About 
**Cloud Storage Abstraction** is a small dll ( on the next iteration, it will be a nuget package) that provides a robust and reusable implementations. 

The main focus is work with CRUD approach with Azure Storage.

## Built With

- [.Net 6.0](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6)
- [c# 11](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)


# Features
- SerializeToStream
- SerializeToStreamAsync
- SerializeToString
- DeserializeFromStream
- DeserializeFromString
- DeserializeFromStreamAsync

# Getting Started
At this point, we have to use this project like dll or directly on our production projects.

On next releases, we transform the solution into nuget. 

## Prerequisites

- [.Net 6.0](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6)
- [c# 11](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)


## Dependencies

- .Net 6.0
- System.Text.Json
- Newtonsoft
- MessagePack

## Installation
At this point, it is possible to use that asset:
- Cloning the repo and use it directly on you solution. On this way, you will have access too entire code. 
- Using the dll located on Release folder

## samples

```c#
 ISerializer serializer = new EA.Serializers.Json.JsonSerializer();
 ISerializer serializer = new EA.Serializers.NewtonsoftJson.JsonSerializer();
 ISerializer serializer = new EA.Serializers.MessagePack.MessagePackSerializer();
```
* take care about that sample are instances directly. In general situation, we should use DI. 
* take a look at the UnitTests project to see it samples of use

# Contributing

Please see our [Contribution Guide](CONTRIBUTING.md) to learn how to contribute.

# License

[MIT](LICENSE) © 2022 [ERNI - Swiss Software Engineering](https://www.betterask.erni)

**Contact:**