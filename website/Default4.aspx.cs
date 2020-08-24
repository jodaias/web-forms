using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class Default4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   Response.Write("====== Esta é uma sessão. funciona nessa pagina =====");
            Response.Write(Session["<br>"]);
            Response.Write(Session["email"]);
            Response.Write(Session["<br>"]);
            Response.Write(Session["senha"]);

            Response.Write("====== Este é um view state. Será que funciona nessa pagina??? não é claro. só na pagina Default2.aspx =====");
            Response.Write("<br>");
            Response.Write(ViewState["dados"]);

        }
    }
}