# The ASP.NET Vue Starter

Hello and welcome to the ASP.NET Vue Starter Template with ASP.NET and Vue 3.0. The only things this template contains are:

 - A starter ASP.NET web application, with no changes
 - A starter Vue 3 app generated using `npm init vue@latest`, no changes
 - Orchestration for hooking the two applications together, which you can see in `Program.cs`.

## Run the Application

To run the application, simply use `dotnet run` which will get things started. Alternatively, you can use `dotnet watch` which will watch your ASP.NET application in the background and restart things when the code changes.

It's important to note that in development you have **two separate web applications running**:

 - An ASP.NET web application with Controllers and Razor Pages, running on port 8080
 - A Vue Application running in development mode with a Node web server, running on port 8088

This can be confusing, but that's how Vue works in development and, you'll find, it's very useful to think of these things as separate applications entirely. The Vue app is your front end, the ASP app is your API which serves data.

The Vue web server will auto-reload and log all the interactions with your Vue application, and you can build your app like you would any other Vue app.

## Deployment

When you create Vue applications, you do so with the help of a web server so you can see what you're creating as you create it. When it comes time to deploy, however, what you've created needs to be "transpiled" into individual JavaScript files and a static HTML page from which to serve them.

This entire process is handled by [Vite](https://vitejs.dev/) (pronounced "veet"), and you don't need to think about it. All you need to remember is the the command you would normally use to take your application live:

```
dotnet publish
```

Running that will trigger the Vue build process (using Vite), which will optimize your view application, which includes:

 - Minification of assets, including CSS and JavaScript
 - Code-splitting or "chunking" your application code based on routes

Again: this can be confusing unless you're used to thinking in terms of frontend and backend. When building an application like this, it's common to put *everything* the user sees int the Vue application. All your pages, images and so on are served by your frontend single page app.

This leads to an important understanding: in production you have only one server running, the ASP.NET server, which will *proxy* your Vue application, which your end user will interact with.

## Questions? Issues?

The [GitHub repo for this template is here](https://github.com/robconery/Vue.Kit). I don't have discussions enabled, but feel free to pop an issue if you like or, better yet, a PR!

