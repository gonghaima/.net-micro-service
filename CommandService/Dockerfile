FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App

# Install bash
RUN apt-get update && apt-get install -y bash

COPY --from=build-env /App/out .
ENTRYPOINT [ "dotnet", "CommandService.dll" ]
