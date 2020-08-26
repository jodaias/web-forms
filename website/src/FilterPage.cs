using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace website.src
{
    public class FilterPage : Page
    {
        public FilterPage()
        {
            this.Page.PreInit += Page_PreInit;
            this.Page.Init += Page_Init;
            this.Page.Load += Page_Load;
            this.Page.LoadComplete += Page_LoadComplete;
        }


        private void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("olá LoadComplete <br><hr><br>");
        }

        private void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("olá Load <br><hr><br>");
        }

        private void Page_Init(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("olá Init <br><hr><br>");
        }
        private void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write(Request["param"]);
            Response.Write("olá preInit <br><hr><br>");
        }

    }
}