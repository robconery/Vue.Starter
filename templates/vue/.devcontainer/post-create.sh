#! /bin/sh

echo "Installing Azure CLI"
curl -fsSL https://aka.ms/install-azd.sh | bash

echo "Restoring .NET dependencies"
cd server
dotnet restore

echo "Restoring Node dependencies"
cd ../app
npm install
