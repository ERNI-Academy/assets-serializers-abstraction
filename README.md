# About

**Cloud Storage Abstraction** is a small dll ( on the next iteration, it will be a nuget package) that provides a robust and reusable implementations.

The main focus is work with CRUD approach with Azure Storage.

<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
<!-- ALL-CONTRIBUTORS-BADGE:END -->

## Built With

- [.Net 6.0](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6)
- [c# 11](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)

## Features

- SerializeToStream
- SerializeToStreamAsync
- SerializeToString
- DeserializeFromStream
- DeserializeFromString
- DeserializeFromStreamAsync

## Getting Started

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

- take care about that sample are instances directly. In general situation, we should use DI.
- take a look at the UnitTests project to see it samples of use

## Contributing

Please see our [Contribution Guide](CONTRIBUTING.md) to learn how to contribute.

## License

![MIT](https://img.shields.io/badge/License-MIT-blue.svg)

(LICENSE) © 2022 [ERNI - Swiss Software Engineering](https://www.betterask.erni)

## Code of conduct

Please see our [Code of Conduct](CODE_OF_CONDUCT.md)

## Stats

![https://repobeats.axiom.co/api/embed/609d8a84f264ec3f0641941c785f96c854efe951.svg](https://repobeats.axiom.co/api/embed/609d8a84f264ec3f0641941c785f96c854efe951.svg)

## Follow us

[![Twitter Follow](https://img.shields.io/twitter/follow/ERNI?style=social)](https://www.twitter.com/ERNI)
[![Twitch Status](https://img.shields.io/twitch/status/erni_academy?label=Twitch%20Erni%20Academy&style=social)](https://www.twitch.tv/erni_academy)
[![YouTube Channel Views](https://img.shields.io/youtube/channel/views/UCkdDcxjml85-Ydn7Dc577WQ?label=Youtube%20Erni%20Academy&style=social)](https://www.youtube.com/channel/UCkdDcxjml85-Ydn7Dc577WQ)
[![Linkedin](https://img.shields.io/badge/linkedin-31k-green?style=social&logo=Linkedin)](https://www.linkedin.com/company/erni)

## Contact

📧 [esp-services@betterask.erni](mailto:esp-services@betterask.erni)

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- ALL-CONTRIBUTORS-LIST:END -->
This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
