FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY MessageDecorator/*.csproj MessageDecorator/
COPY MessageDecorator.Tests/*.csproj MessageDecorator.Tests/

RUN dotnet restore MessageDecorator/MessageDecorator.csproj

COPY MessageDecorator/ MessageDecorator/
COPY MessageDecorator.Tests/ MessageDecorator.Tests/

RUN dotnet build MessageDecorator/MessageDecorator.csproj --configuration Release --no-restore

RUN dotnet test MessageDecorator.Tests/MessageDecorator.Tests.csproj --no-build --verbosity normal