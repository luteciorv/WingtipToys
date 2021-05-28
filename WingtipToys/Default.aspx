<%@ Page Title="Bem-vindo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WingtipToys._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Título da página -->
    <h1><%: Title %>.</h1>

    <!-- Descrição do site -->
    <h2>Wingtip Toys pode ajudar você a encontrar o presente perfeito.</h2>
    <p class="lead"> Nós lidamos com tudo que envolva transporte. Você
        pode pedir qualquer um de nossos produtos hoje mesmo. Cada produto
        listado contém informações detalhadas para ajudar você a escolher o
        produto certo!
    </p>

</asp:Content>
