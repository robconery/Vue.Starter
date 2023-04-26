# Azure Deployment Scripts

In this directory are deployment scripts ready to use. This requires that you have the Azure CLI installed (`az`) and are logged in to the account you want to deploy with.

## Setting up your Azure Resources

To run this application you need a web server that runs .NET 7, that's it. Node is not required as all of the front end components are built during `dotnet build`, which happens when you `dotnet publish`.

For convenience, we've added a setup script in this here directory called `app_service.sh`, which is a script that creates the necessary services on Azure for you. 

From the server project root:

```
source ./Deployment/Azure/app_service.sh
```

Please have a read and change things as you need **before you run this script**. It will run in Powershell as well as bash and the only thing you need to do is **change the variables at the top**.

## Deploying

When you run the `app_service.sh` script, a second script will be created for you called `zip.sh`. This is how your code will end up on Azure hardware: it's zipped up and pushed:

```
source ./Deployment/Azure/zip.sh
```

For fun and convenience we've added a Makefile which will execute this for you:

```
make app_service && make
```

Yay for Make!

## What's going on during deployment

Once everything is ready to go (after `dotnet publish`) your deployment artifacts will be located in `/bin/Release/net7.0/publish`, which includes the Vue application, which is built along with the ASP.NET application.

The built Vue application is located in `wwwroot` in that directory which is where it needs to live.

This entire directory is being zipped up and pushed to Azure and once that's done, a browser will open to your site's directory and the logs for the application will be streamed for you so you know what's going on.

If there are any problems you can drop all of your resources using `az group delete -n [NAME]` where `NAME` is the resource group name you came up with (`RG` in the script).

Have fun!

