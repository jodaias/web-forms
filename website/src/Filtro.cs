using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace website
{
    public class Filtro : Page
    {
        public Filtro()
        {
            this.Page.PreInit += Page_PreInit;
        }

        private void Page_PreInit(object sender, EventArgs e)
        {
            var nome = this.ToString();
            Response.Write(nome);
        }
    }
}