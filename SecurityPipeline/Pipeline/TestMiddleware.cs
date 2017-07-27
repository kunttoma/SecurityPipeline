using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SecurityPipeline.Pipeline
{
    public class TestMiddleware
    {
        private Func<IDictionary<string, object>, Task> _next;

        public TestMiddleware(Func<IDictionary<string, object>, Task> nextInPipe)
        {
            _next = nextInPipe;
        }

        //the one that does the work very much like module
        public async Task Invoke(IDictionary<string, object> env)
        {
            // yu can probe the dictionary or helper class
            var context = new OwinContext(env);

            //authentication code to be here




            Helper.Write("Middleware", context.Request.User);

            await _next(env);

        }
    }
}