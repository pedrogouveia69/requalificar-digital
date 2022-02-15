using System.Diagnostics;

namespace Ficha9
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate next;

        public CustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Debug.WriteLine("BEFORE CUSTOM MIDDLEWARE");
            await next(context);
            Debug.WriteLine("AFTER CUSTOM MIDDLEWARE");
        }
    }
}
