FROM mcr.microsoft.com/dotnet/runtime-deps:6.0-alpine-amd64

EXPOSE 8080

# Copy 
RUN mkdir /app
WORKDIR /app
COPY ./linux64_musl/. ./

ENTRYPOINT ["dotnet", "QuadraticEquationCalculator.Server.dll"]