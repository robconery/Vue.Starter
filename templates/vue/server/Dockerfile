FROM node:latest AS node_base
RUN echo "NODE Version:" && node --version
RUN echo "NPM Version:" && npm --version

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
COPY --from=node_base . .
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0

ARG ENTRYPOINT_DLL=Vue.Starter.dll
ENV ENTRYPOINT_DLL="${ENTRYPOINT_DLL}"

COPY --from=node_base . .
WORKDIR /App
COPY --from=build-env /App/out .
EXPOSE 80

# ENTRYPOINT ["dotnet", "Vue.Starter.dll"]
ENTRYPOINT ["/bin/bash", "-c", "dotnet $ENTRYPOINT_DLL"]
