using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecurityPipeline.Pipeline
{

    //to add owin support,
    // we need support asp.net to owin, and webapi that receives from owin
    //systemweb.owin
    //web api owin
    [TestAuthenticationFilter]
    [TestAuthorizationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            // either User or via context
            var principal = Request.GetRequestContext().Principal;
            var user = this.User;
            Helper.Write("Controller", principal);
            return Ok();
        }
    }
}
