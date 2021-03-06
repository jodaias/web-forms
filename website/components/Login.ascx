﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="website.Login" %>
<div class="login">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ControlToValidate="txtLogin" ErrorMessage="Preenchimento do Login é obrigatório" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvSenha" runat="server" ControlToValidate="txtSenha" ErrorMessage="Preenchimento do Senha é obrigatório" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000"/>
    <br />
    <div>
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
    </div>
<br />
<br />
<asp:Label ID="lblMensagem" runat="server" Text="[Mensagem]"></asp:Label>

    <br />

</div>
