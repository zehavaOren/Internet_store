using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using webProjeact;

namespace webProjeact
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CashingMiddleware
    {
        private readonly RequestDelegate _next;

        public CashingMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.GetTypedHeaders().CacheControl =
             new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
             {
                 Public = true,
                 MaxAge = TimeSpan.FromSeconds(40)
             };
            httpContext.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
            new string[] { "Accept-Encoding" };
            await _next(httpContext);
            //return _next(httpContext);
        }
    }



// Extension method used to add the middleware to the HTTP request pipeline.
public static class CashingMiddlewareExtensions
    {
        public static IApplicationBuilder UseCashingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CashingMiddleware>();
        }
    }

}