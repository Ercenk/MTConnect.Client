# MTConnect.Client
This is a .NET Core library using the generated code from the OpenAPI 2.0 (Swagger) sample spec for the MTConnect 1.3.1 defined at the repo https://github.com/Ercenk/MTConnect.OpenAPI.

## Story

As I started working on this project during a weekend, I encountered a few things.

* **Target language/framework**: I like C#, I am comfortable with it, thus I looked at the swagger-codegen (https://github.com/swagger-api/swagger-codegen). I noticed it uses RestSharp package. I have nothing against that fantastic package, however, I have worked with Microsoft.Rest.ClientRuntime (https://www.nuget.org/packages/Microsoft.Rest.ClientRuntime/) a lot, and have used Microsoft's AutoRest tool for generating client code before (https://github.com/Azure/autorest). It can generate code in C#, Go, Java, Node.js, TypeScript, Ruby and PHP, plus it has been battle tested on Azure SDKs. I also wanted to use .NET Core (https://www.microsoft.com/net/download/windows) so I can target multiple platforms with C#.
* **POCO types for the results**: They are generated using xsd.exe, however each schema refers to the same Header type. I had to manually remove them from the generated files, and create a single type for the Header.
* **Client Code Generation with Docker**: Installing a lot of software on a dev box is my pet peeve. I try to avoid it. Docker is the perfect solution for it. Thus the generate.sh and generate.cmd scripts. They use Docker to run an autorest container, generate the files, and move them to their new destination.
* **MTConnect version**: MTConnect Institute recently released version 1.4, however most of the data out there is using version 1.3.1. The first spec I attempted is for 1.3.1.

## Bottom Line

* Swagger spec is there for you to use as a starting point
* I generated C# client code from it, and planning to use in another project
* I had to do some manual work on the generated POCO types

## Limitations 

* I did not test all of the operations, but a few.
* I did not implement the cases when an MTConnectError is returned.


## Nuget package

The client is also available at nuget, [https://www.nuget.org/packages/MTConnect.Client/](https://www.nuget.org/packages/MTConnect.Client/)

## How to use

```cs
    this.client = new MTConnectClient("https://smstestbed.nist.gov/vds");

    var all = await this.client.ProbeAsync();

    var first = await this.client.CurrentAsync(all.Devices.First().id);
```