# See https://aka.ms/customizecontainer to learn how to customize your debug container
# and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
COPY . /src
WORKDIR /src
RUN dotnet restore "Server/QuadraticEquationCalculator.Server.csproj"
WORKDIR "/src/Server"
RUN dotnet build "QuadraticEquationCalculator.Server.csproj" -c Release -f net7.0 -o /app/build

FROM build AS publish
RUN dotnet publish "QuadraticEquationCalculator.Server.csproj" -c Release -f net7.0 -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QuadraticEquationCalculator.Server.dll"]