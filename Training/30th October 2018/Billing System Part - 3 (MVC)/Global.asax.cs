using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BillingSystem
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("==================================Application Start===========================");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("====================================Session Start===========================");

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("===============================Application Begin Request===========================");

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("============================Application AuthRequest===========================");

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("============================Application Error===========================");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("===========================Session End===========================");

        }

        protected void Application_End(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("=====================Application End===========================");

        }
    }
}