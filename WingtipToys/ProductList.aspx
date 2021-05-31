<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WingtipToys.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <section>
        <div>
            <hgroup>
                <h2><%:Page.Title %></h2>
            </hgroup>

            <!-- List View dos produtos -->
            <asp:ListView ID="ProductList" runat="server"
                DataKeyNames="ProductID" GroupItemCount="4"
                ItemType="WingtipToys.Models.Product" SelectMethod="GetProducts">

                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>Nenhum dado foi retornado;.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>

                <EmptyDataTemplate>
                    <td></td>
                </EmptyDataTemplate>

                <GroupTemplate>
                    <tr id="ItemPlaceholderContainer" runat="server">
                        <td id="ItemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>

                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID %>">
                                        <img src="/Catalog/Images/Thumbs/<%#:Item.ImagePath %>" 
                                            width="100" height="75" style="border: solid"/>                                        
                                    </a>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID %>">
                                        <spam>
                                            <%#:Item.ProductName %>
                                        </spam>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Preço: </b><%#:string.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                
                <LayoutTemplate>
                    <table style="width: 100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="GroupPlaceholderContainer" runat="server" style="width: 100%">
                                        <tr id="GroupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
