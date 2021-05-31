<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WingtipToys.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Formulário com os dados do produto selecionado -->
    <asp:FormView ID="productDetail" runat="server" ItemType="WingtipToys.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/<%#:Item.ImagePath %>" style="border: solid; height:300px" alt="<%#:Item.ProductName %>" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left">
                        <b>Descrição:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Preço:</b>&nbsp;<%#:string.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Número do produto:</b>&nbsp;<%#:Item.ProductID %></span>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
