<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBeDia.View.Master.ViewProduct.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center; width:auto; margin-left:auto;margin-right:auto;">View Products</h1>
    <br />
    <asp:Button runat="server" OnClick="btnLogin_Click" ID="btnLogin" Text="Home" />
    <br />
    <br />
    <div id="Admin" runat="server" visible="false">
        <asp:Button runat="server" ID="btnInsertProduct" Text="Insert Product" OnClick="btnInsertProduct_Click"/>
    </div>
    <table border="1" style="text-align:center; width:auto; margin-left:auto;margin-right:auto;">
        <thead>
            <tr>
                <th>Product ID</th>
                <th>Product Name</th>
                <th>Product Stock</th>
                <th>Product Type</th>
                <th>Product Quantity</th>
                <div runat="server" id="AdminHeader" visible="false">
                    <th>Action</th>
                </div>                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="rptProducts" OnItemDataBound="rptProducts_ItemDataBound" OnItemCommand="rptProducts_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <td><asp:Label runat="server" ID="lblProductID"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductName"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductStock"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductType"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductQuantity"></asp:Label></td>
                        <div runat ="server" id="AdminAction" visible="false">
                            <td>
                                <asp:Button runat="server" ID="lbUpdate" Text="Update" CommandName="Update"></asp:Button>
                                <asp:Button runat="server" ID="lbDelete" Text="Delete" CommandName="Delete"></asp:Button>
                            </td>
                        </div>                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
