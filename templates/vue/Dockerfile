# This is a multi-stage build so we'll start with a Node image
FROM node:latest AS node_base
RUN echo "NODE Version:" && node --version
RUN echo "NPM Version:" && npm --version

# Now create a .NET image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Copy the node  into the .NET image
COPY --from=node_base . .

# The default app directory for Linux and .NET
# this is not the same as our project's /app
WORKDIR /App

# Copy everything - both /app and /server
COPY . ./

# change into the server directory we need to run a few commands
WORKDIR /App/server

# Restore as distinct layers
RUN dotnet restore

# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0

WORKDIR /App
COPY --from=build-env /App/server/out .
EXPOSE 80

ENTRYPOINT ["dotnet", "Vue.Starter.dll"]

