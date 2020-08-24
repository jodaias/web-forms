using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class Login : System.Web.UI.UserControl
    {
        public string Mensagem;
        public string login;
        public string senha;
        protected void Page_Load(object sender, EventArgs e)
        {   
            lblMensagem.Text = Mensagem;
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {

            senha = txtSenha.Text;
            login = txtLogin.Text;

            Session["email"] = login;
            Session["senha"] = senha;

            if (login == "jodaias" && senha == "12345678")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "<script>alert('" + login + " entrou com sucesso.');</script>");
                Response.Redirect("/");
            }
            else
            {
                Session["email"] = null;
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "<script>alert('" + login + " não existe na base de dados.');</script>");
            }
        }
    }
}