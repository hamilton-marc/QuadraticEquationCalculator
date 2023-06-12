# QuadraticEquationCalculator
A simple Blazor WebAssembly App with ASP.NET which calculates the roots of a quadratic equation given the coefficients as inputs.

The quadratic equation is <em>ax<sup>2</sup> + bx + c = 0</em>.

This application determines the roots (x) given the coefficients a and b as well as the constant c as inputs.

The application is written using Blazor WebAssembly hosted by an ASP.NET Core backend.

## Installing / Getting started

### Prerequisites

Be sure you have .NET Framework 6.0 which is cross platform and will run on Windows, Mac and Linux. You can find the .NET 6.0 SDK at Microsoft's [dotnet download site](https://dotnet.microsoft.com/en-us/download).

### Install Dependencies

To restore the dependencies for all of the underlying projects, from the root directory of the solution run the following using the dotnet CLI:

```shell
dotnet restore
```

### Build

To build the solution for the target framework for all of the underlying projects, use the build command from the dotnet CLI:

```shell
dotnet build
```

## Run the application locally

To run the application locally, make sure the startup project is `Server\QuadraticEquationCalculator.Server.csproj` in Visual Studio, or simply use the CLI:

```shell
dotnet run --project Server\QuadraticEquationCalculator.Server.csproj
```

### Run the application locally

Navigate to `http://localhost:<port>` where `<port>` is the port number that the application is running on. You should see the home page rendered for the application.

### API Swagger Doc

To see the Swagger documentation for the API, navigate to the following URL:

`http://localhost:<port>/swagger`

From the Swagger interface, you can optionally interact with the API.

#### Examples

The following will return 2 real and imaginary roots solving for the quadratic equation is <em>ax<sup>2</sup> + bx + c = 0</em> where a = 6, b = -3 and c = 2.

`http://localhost:<port>/api/QuadraticRoots?a=6&b=-3&c=2`

## Executing the Unit Tests

The unit tests were developed using xUnit and can be executed with the following
command.

```shell
dotnet test
```
## Licensing

The code in this project is licensed under MIT license.