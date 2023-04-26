# The ASP.NET Vue Starter

Hello and welcome to the ASP.NET Vue Starter Template with ASP.NET Minimal API and Vue 3.0. The only things this template contains are:

 - A starter ASP.NET Minimal API in `/server`. It has been setup to serve...
 - A starter Vue 3 app generated using `npm init vue@latest` in the `/app` directory.

Before you get started, however, be sure to navigate into the `/app` directory and:

```
npm init
```

This will pull down the packages you need for Vue to run.

## Running Things

To get up and running for development, you can run this right from the root:

```
npm run dev
```

If you only want to do Vue work you can run `npm run dev` in the `/app` directory but do keep in mind the backend API won't be running.

## Up and Running

To get you started quickly we've integrated Tailwind CSS, which is quickly becoming the default CSS library for projects such as Rails and Phoenix. If you don't know Tailwind, it can be a little intimidating at first but if you spend just 30 minutes on the basics, it will change the way you do things.

To find out more, you can [head to the docs](https://tailwindcss.com/docs/installation).

### Starter Components

We've added a few starter components for you in `/app/src/components` which were built using the elements from [Tailblocks](https://tailblocks.cc/), a free, open-source block library for Tailwind.

## Simple CMS API

We love Markdown and we love using it with Vue. We also love the way Vue pushes you away from hardcoding data and markup in your components so, to that end, we've created a super simple CMS system for you to use via the Minimal API which is based on [Nuxt Content](https://content.nuxtjs.org/).

The idea is simple: your documents are loaded at startup, parsed and added to a `Document` collection. These documents can then be queried using LINQ via the API. Have a look in the `/Content` directory to see the documents.

## Minimal API

[ASP.NET Minimal API](https://minimal-apis.github.io/) is a new effort from Microsoft's ASP.NET team to help you rapidly build your application:

> Rapidly move from idea to a functioning application. All the features of C# web applications without the ceremony.

As you'll hopefully see, Minimal API *feels* like lightweight web frameworks in other platforms, such as Flask (Python), Sinatra (Ruby) and Express (Node). Lightweight, easy to use and blazingly fast.


## Deployment

When you create Vue applications, you do so with the help of a web server so you can see what you're creating as you create it. When it comes time to deploy, however, what you've created needs to be "transpiled" into individual JavaScript files and a static HTML page from which to serve them.

This entire process is handled by [Vite](https://vitejs.dev/) (pronounced "veet"), and you don't need to think about it. All you need to remember is the the command you would normally use to take your application live:

```
dotnet publish
```

Running that will trigger the Vue build process (using Vite), which will optimize your view application, which includes:

 - Minification of assets, including CSS and JavaScript
 - Code-splitting or "chunking" your application code based on routes
 - Adding the built files to `/wwwroot` where it will be served as a static application, backed by your Minimal API

It's important that this step is run prior to deployment, otherwise you won't see your assets.

## Azure Deployment

In the `/server/Deployment/Azure` directory you'll see two script files:

 - `app_service.sh` is the script file that will help you create the resource on Azure that you need. It will also create a...
 - `zip.sh` file, which will push your site up using a direct zip push. This file is generated, but if you need to reproduce it manually, it looks something like this:

```sh
rm ./Deployment/Azure/deploy.zip
rm -R bin/Release
dotnet publish --configuration Release
cd bin/Release/net7.0/publish/
zip -r ../../../../Deployment/Azure/deploy.zip . -q
cd -
az webapp deployment source config-zip --resource-group $RG --name $APPNAME --src ./Deployment/Azure/deploy.zip
open https://$APPNAME.azurewebsites.net
echo 'Site's been pushed, watching logs...'
az webapp log tail -n $APPNAME -g $RG
```

## Using Make

If you're a CLI person we've created a Makefile for you in the root of the `/server` application. You can use this to spin up your Azure resources using `make app_service` and to deploy your app using just `make`.

In the long term you'll obviously want to use a more structured deployment process and we're currently working on a simple way to "upgrade" to a GitHub based deployment.

## Docker

There is a Dockerfile in the root of the project that will build and package everything for you when you need it. This is _only_ the deployable application, not meant for development. To use it, just...

```sh
docker build -t Vue.Starter .
docker run -p 8080:80 Vue.Starter
# open http://localhost:8080
```

## Questions? Issues?

The [GitHub repo for this template is here](https://github.com/robconery/Vue.Starter). I don't have discussions enabled, but feel free to pop an issue if you like or, better yet, a PR!

