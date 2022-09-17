namespace DependencyInjecionAndMiddleWare.Infrastructure
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate _requestDelegate;
        public ShortCircuitMiddleware(RequestDelegate requestDelegate)
        {
            this._requestDelegate = requestDelegate;
        }

        /*
             Short-Circuit md. amacı: Bir content oluşmadan ÖNCE onun denetimini sağlamak.
             Edge tarayıcı denetimi...
        */

        // httpContext.Request.Headers["User-Agent"].Any(h => h.ToLower().Contains("trident"));
 

        public async Task Invoke(HttpContext httpContext)
        {

            var result = httpContext.Request.Headers["User-Agent"].Any(h => h.ToLower().Contains("trident"));

            if (httpContext.Items["IE"] as bool? == true)
            {
                httpContext.Response.StatusCode = 403;
            }
            else
            {
                await _requestDelegate.Invoke(httpContext);
            }
        }
    }


    public class ContentMiddleWare
    {
        private RequestDelegate _requestDelegate;
    }
}
