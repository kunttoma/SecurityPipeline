using System;
using System.Web;

namespace SecurityPipeline.Pipeline
{
    // Module is IIS thing
    public class HttpModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            Helper.Write("HttpModule", HttpContext.Current.User);

        }

        public void Dispose()
        { }
        #endregion IHttpModule Members
    }
}
