[![Nuget](https://img.shields.io/nuget/v/SimpleRestSharp)](https://www.nuget.org/packages/SimpleRestSharp/)

# OpenIbanSharp

C# .NET Standard library wrapper for OpenIban.

## Getting Started

Clone the repository and open in Visual Studio. Build the code and reference the .dll file.

Create an instance of `OpenIbanClient` by providing the url where the [goiban-service](https://github.com/fourcube/goiban-service) is running as a parameter in the constructor.

## Usage


`OpenIbanClient` has only 1 method, `Validate(string iban)`, which returns a `BankResponse`-object.

### Dependencies

* A server running the [goiban-service](https://github.com/fourcube/goiban-service)
* .NET Standard 2.0
* [RestSharp](https://github.com/restsharp/RestSharp)
* [SimpleRestSharp](https://github.com/MichelMichels/SimpleRestSharp)

## License

This project is licensed under the Apache-2.0 License - see the [LICENSE](LICENSE) file for details