namespace Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Enable rewinding of requests in order to help other middlewares.
    /// </summary>
    public class EnableRequestRewindMiddleware
    {
        private readonly RequestDelegate _next;

        public EnableRequestRewindMiddleware(RequestDelegate next) => _next = next;

        public Task Invoke(HttpContext context)
        {
            context.Request.EnableBuffering();
            return _next(context);
        }
    }
}
