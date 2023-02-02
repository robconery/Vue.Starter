# The ASP.NET Vue Starter

Hello and welcome to the ASP.NET Vue Starter Template with ASP.NET Minimal API and Vue 3.0. The only things this template contains are:

 - A starter ASP.NET Minimal API in `/server`. It has been setup to serve...
 - A starter Vue 3 app generated using `npm init vue@latest` in the `/client` directory.

You can run these applications independently or together, however you need. To run the server, navigate to the server directory and run:

```
dotnet watch
```

To run the client, navigate to the `/client` directory and run:

```
npm run dev
```

These projects are (currently) set up to be developed separately and, therefore, you run them independently with the above commands during development.

When you're ready to test them together, you can run `npm build` from the `/client` directory, which will build the Vue application and place the output in the `/wwwroot` directory

## Using the Scripts

For convenience, there is a set of shell scripts in the `/scripts` directory to help you with common tasks, such as building and running the application using .NET, setting up Azure and also deployment.

## Deployment

When you create Vue applications, you do so with the help of a web server so you can see what you're creating as you create it. When it comes time to deploy, however, what you've created needs to be "transpiled" into individual JavaScript files and a static HTML page from which to serve them.

This entire process is handled by [Vite](https://vitejs.dev/) (pronounced "veet"), and you don't need to think about it. All you need to remember is the the command you would normally use to take your application live:

```
dotnet publish
```

Running that will trigger the Vue build process (using Vite), which will optimize your view application, which includes:

 - Minification of assets, including CSS and JavaScript
 - Code-splitting or "chunking" your application code based on routes

It's important that this step is run prior to deployment, otherwise you won't see your assets. For convenience, we've setup a script for you but it might also be worth your while to 


## Questions? Issues?

The [GitHub repo for this template is here](https://github.com/robconery/Vue.Starter). I don't have discussions enabled, but feel free to pop an issue if you like or, better yet, a PR!

