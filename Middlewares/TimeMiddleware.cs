using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Middlewares
{
    public class TimeMiddleware
    {
        // Nos permite darle continuidad al middleware siguiente
        readonly RequestDelegate next;

        public TimeMiddleware(RequestDelegate nextRequest)
        {
            next = nextRequest;
        }

        //Metodo por defecto que tienen todos los middleware
        // HttpContext constext representa el request
        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
        {

            await next(context);
            if( context.Request.Query.Any( p => p.Key == "time") )
            {
                await context.Response.WriteAsync( DateTime.Now.ToShortTimeString() );
            }
        }

    }

    public static class TimeMiddlewareExtension
    {
        public static IApplicationBuilder useTimeMiddleware( this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMiddleware>();
        }
    }
}