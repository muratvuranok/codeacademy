namespace CodeEduAz.Middlewares
{
    public class FirstCustomMiddleware
    {
        private readonly RequestDelegate _next;
        public FirstCustomMiddleware(RequestDelegate next)
        {
            this._next = next;
        }


        public async Task Invoke(HttpContext context)
        {
           
            // logical operations
            Console.WriteLine("FirstCustomMiddleware -> Start (Hello World)");
            await _next.Invoke(context);
            Console.WriteLine("FirstCustomMiddleware -> End (Good by World)");

        }
    }
}
