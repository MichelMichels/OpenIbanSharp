<!-- omit in toc -->
# OpenIbanSharp 💳

[![Nuget](https://img.shields.io/nuget/v/MichelMichels.OpenIbanSharp)](https://www.nuget.org/packages/MichelMichels.OpenIbanSharp/)
[![.NET](https://github.com/MichelMichels/OpenIbanSharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MichelMichels/OpenIbanSharp/actions/workflows/dotnet.yml)

This projects is a C# wrapper library to [validate IBAN numbers with go-iban]("https://openiban.com/").

<details>
<summary>Table of Contents</summary>

- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Building](#building)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)
- [Credits](#credits)

</details>

<hr>

## Prerequisites
- [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- A server running the [goiban-service](https://github.com/fourcube/goiban-service). F.e. `https://openiban.com`, but you can also self-host and use your own server.

## Getting Started

Clone the repository and open in Visual Studio. Build the code and reference the .dll file.

Create an instance of `OpenIbanClient` by providing the url where the [goiban-service](https://github.com/fourcube/goiban-service) is running as a parameter in the constructor.




<br />


## Building

Use [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) to build the project. 

<br />


## Installation

Get the NuGet packages from [nuget.org](https://www.nuget.org/) or search for `MichelMichels.OpenIbanSharp` in the GUI package manager in Visual Studio.

You can also use the cli of the package manager with following command:

```cli
Install-Package MichelMichels.OpenIbanSharp
```

<br />

## Usage

`OpenIbanClient` has only 1 method, `Validate(string iban)`, which returns a `BankResponse`-object.

<br />

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

<br />

## Credits

Written by [Michel Michels](https://github.com/MichelMichels).

<br />
