using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure.Middleware
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;

        public TestMiddleware(RequestDelegate Next) => _next = Next;

        public async Task Invoke(HttpContext context)
        {
            //context.Response.StatusCode = 404;

            await _next(context);
             
        }
    }
}
