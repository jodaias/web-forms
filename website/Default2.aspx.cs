using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("====== Esta é uma sessão. funciona nessa pagina =====");
            Response.Write(Session["<br>"]); 
            Response.Write(Session["email"]);
            Response.Write(Session["<br>"]);
            Response.Write(Session["senha"]);
        }

        protected void btnAddViewState_Click(object sender, EventArgs e)
        {
            ViewState["dados"] = "Jodaías";
        }

        protected void btnEscreverViewState_Click(object sender, EventArgs e)
        {
            Response.Write("====== Este é um view state. Só funciona nessa página =====");
            Response.Write(ViewState["dados"]);
        }
    }
}