<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default2.aspx.cs" Inherits="website.Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
   
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    Content page 1
    <ul>
        <li><a href="../Default.aspx">Home</a></li>
        <li><a href="../Default2.aspx">Página 1</a></li>
        <li><a href="../Default3.aspx">Página 2</a></li>
        <li><a href="../Default4.aspx">Página 3</a></li>
        <li></li>
    </ul>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="footer" runat="server">
    footer<br />
    <a href="../Default3.aspx">
    <asp:Button ID="btnAddViewState" runat="server" OnClick="btnAddViewState_Click" Text="Add view state" />
    </a>
    <br />
    <a href="../Default3.aspx">
    <asp:Button ID="btnEscreverViewState" runat="server" OnClick="btnEscreverViewState_Click" Text="Write View State" />
    </a>&nbsp;</asp:Content>
