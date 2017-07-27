using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace SecurityPipeline.Pipeline
{
    public class TestAuthorizationFilter: AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {

            // custom authorization 
            Helper.Write("AuthorizationFilter", actionContext.RequestContext.Principal);
            return true;
            //return base.IsAuthorized(actionContext);
        }
    }
}