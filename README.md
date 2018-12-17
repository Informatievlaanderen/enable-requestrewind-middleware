# Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware.EnableRequestRewind

Middleware component which enables rewinding of requests in order to help other middlewares.

## Usage

```csharp
public void Configure(IApplicationBuilder app, ...)
{
    app
        ...
        .UseMiddleware<EnableRequestRewindMiddleware>()
        ...
}
```
