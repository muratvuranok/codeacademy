using DependencyInjecionAndMiddleWare.Infrastructure;

namespace DependencyInjecionAndMiddleWare.Extentions
{
    public static class ApplicationExtention
    {
        public static IApplicationBuilder USeContent(this IApplicationBuilder app, bool? isEnabled = null)
        {
            if (isEnabled.Value)
            {
                app.UseMiddleware<ShortCircuitMiddleware>();
            }

            //return app.UseMiddleware<ContentMiddleWare>();
            return app.UseMiddleware<ShortCircuitMiddleware>();
        }
    }
}
