<%@ Page Title="Senha Alterada" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResetPasswordConfirmation.aspx.cs" Inherits="WingtipToys.Account.ResetPasswordConfirmation" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <div>
        <p>Sua senha foi alterada. Clique <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Account/Login">aqui</asp:HyperLink> para fazer logon </p>
    </div>
</asp:Content>
