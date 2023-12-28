using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Service;
using Entity;

namespace webProjeact
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RaingMiddleware
    {
        private readonly RequestDelegate _next;

        public RaingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task<Task> Invoke(HttpContext httpContext, IRatingService ratingService)
        {
            Rating rating=new Rating { Host= httpContext.Request.Host.ToString(), Method= httpContext.Request.Method, Path=httpContext.Request.Path, Referer=httpContext.Request.Headers["Referer"], UserAgent=httpContext.Request.Headers["User-Agent"], RecordDate= DateTime.Now };
             await ratingService.AddRatingDeatils(rating);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RaingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRaingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RaingMiddleware>();
        }
    }
}
