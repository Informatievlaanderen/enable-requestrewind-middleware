# Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware.EnableRequestRewind [![Build Status](https://github.com/Informatievlaanderen/enable-requestrewind-middleware/workflows/Build/badge.svg)](https://github.com/Informatievlaanderen/enable-requestrewind-middleware/actions)

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
