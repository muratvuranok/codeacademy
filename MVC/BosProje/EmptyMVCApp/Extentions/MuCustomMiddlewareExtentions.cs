using CodeEduAz.Middlewares;

namespace CodeEduAz.Extentions
{
    public static class MuCustomMiddlewareExtentions
    {
        public static IApplicationBuilder UseMyFirstMiddleware(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<FirstCustomMiddleware>();
        }
    }
}
