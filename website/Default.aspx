<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="website.Default" %>

<%@ Register Src="components/Login.ascx" TagName="Login" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    header
    
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    HOME
    <br />
    <div id="naoLogado" runat="server">
        <uc1:Login ID="ctrLogin" runat="server" />
    </div>
    <!-- Logado no sistema-->
    <div id="Logado" runat="server">
        <ul>
            <li><a href="../Default.aspx">Home</a></li>
            <li><a href="../Default2.aspx">Página 1</a></li>
            <li><a href="../Default3.aspx">Página 2</a></li>
            <li><a href="../Default4.aspx">Página 3</a></li>
        </ul>
        &nbsp;<br />
        <br />
        <asp:DropDownList ID="ddlContatos" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="footer" runat="server">
    footer
</asp:Content>
