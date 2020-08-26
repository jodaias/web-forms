<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="website.Cadastro" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="scripts/jquery.cookie.js"></script>
    <style>
        img {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a href="../Default.aspx">Home</a></li>
                <li><a href="../Cadastro.aspx">Cadastro</a></li>
                <li><a href="../Default2.aspx">Página 1</a></li>
                <li><a href="../Default3.aspx">Página 2</a></li>
                <li><a href="../Default4.aspx">Página 3</a></li>
            </ul>
            <asp:Panel ID="pnlCamposDeCadastro" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Foto"></asp:Label>
                <asp:FileUpload ID="fileFoto" runat="server" />
                <br />
                <br />
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </asp:Panel>
        </div>
        <asp:Panel ID="pnlResultado" runat="server">
            <asp:Button ID="btnNovoCadastro" runat="server" Text="Novo Cadastro" OnClick="btnNovoCadastro_Click" />
            <hr />
            <asp:GridView ID="gridResultado" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                    <asp:ImageField DataImageUrlField="Foto" HeaderText="Foto">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
