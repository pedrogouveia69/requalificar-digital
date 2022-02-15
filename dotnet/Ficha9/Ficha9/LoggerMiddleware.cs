using System.Diagnostics;

namespace Ficha9
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate next;

        public LoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            File.AppendAllText("log.txt", String.Format("BEFORE: {0}, {1}, {2}\n", context.Request.Path, context.Request.Method, DateTime.Now));
            await next(context);
            File.AppendAllText("log.txt", String.Format("AFTER: {0}, {1}, {2}\n", context.Request.Path, context.Request.Method, DateTime.Now));
        }
    }
}