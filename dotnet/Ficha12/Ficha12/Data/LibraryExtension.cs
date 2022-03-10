using Ficha12.Models;

namespace Ficha12.Data
{
    public static class LibraryExtension
    {
        public static IApplicationBuilder UseLibraryContext(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LibraryContext>();
        }

        public static void CreateDbIfNotExists(this IHost host)
        {
            {
                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var context = services.GetRequiredService<LibraryContext>();

                    if (context.Database.EnsureCreated())
                    {
                        LibraryDBInitializer.InsertData(context);
                    }
                }
            }
        }


    }
}
