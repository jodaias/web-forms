using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Contato> contatos = new List<Contato>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Logado.Visible = false;
                naoLogado.Visible = true;
            }
            else
            {
                
                naoLogado.Visible = false;
                Logado.Visible = true;

                Response.Write(Session["email"]);
                Response.Write("<br>");
                Response.Write(Session["senha"]);

                
                contatos.Add(new Contato() { ID = 1, Nome = "Jodaías", Telefone = "75991169903" });
                contatos.Add(new Contato() { ID = 2, Nome = "Laura", Telefone = "75991169904" });
                contatos.Add(new Contato() { ID = 3, Nome = "Marcos", Telefone = "75991169905" });
                contatos.Add(new Contato() { ID = 4, Nome = "Robério", Telefone = "75991169906" });

                ddlContatos.DataSource = contatos;
                ddlContatos.DataValueField = "ID";
                ddlContatos.DataTextField = "Nome";
                ddlContatos.DataBind();

                GridView1.DataSource = contatos;
                GridView1.DataBind();
                
            }

        }
    }
}