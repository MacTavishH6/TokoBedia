<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TokoBeDia.View.Master.Home.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .WelcomeText{
            font-size: 50px;
            display: block;
            width:100%;
            text-align:center;
        }
        .Button{
            width:100%;
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="WelcomeText">
        <asp:Label runat="server" ID="lblWelcome"></asp:Label>
    </div>
    <br />
    <br />

    <div class="Button" id="divGuest" runat="server" visible="false">
        <asp:Button runat="server" OnClick="btnViewProduct_Click" ID="btnViewProduct" Text="View Product" />
        <asp:Button runat="server" OnClick="btnLogin_Click" ID="btnLogin" Text="Login" />
    </div>
    

    <div class="Button" id="divLoggedOn" runat="server" visible="false">
        <asp:Button runat="server" OnClick="btnViewProductLoggedOn_Click" ID="btnViewProductLoggedOn" Text="View Product" />
        <asp:Button runat="server" OnClick="btnViewProfile_Click" ID="btnViewProfile" Text="View Profile" />
        <asp:Button runat="server" OnClick="btnLogout_Click" ID="btnLogout" Text="Logout" />
    </div>
    <br />
    <div class="Button" id="divAdmin" runat="server" visible="false">
        <asp:Button runat="server" OnClick="btnViewUser_Click" ID="btnViewUser" Text="View User" />
        <asp:Button runat="server" OnClick="btnInsertProduct_Click" ID="btnInsertProduct" Text="Insert Product" />
        <asp:Button runat="server" OnClick="btnUpdateProduce_Click" ID="btnUpdateProduce" Text="Update Product" />
        <asp:Button runat="server" OnClick="btnViewProductType_Click" ID="btnViewProductType" Text="View Product Type" />
        <asp:Button runat="server" OnClick="btnInsertProductType_Click" ID="btnInsertProductType" Text="Insert Product Type" />
        <asp:Button runat="server" OnClick="btnUpdateProductType_Click" ID="btnUpdateProductType" Text="Update Product Type" />
    </div>
    <div runat="server" id="table">
        <table border="1" style="text-align:center; width:auto; margin-left:auto;margin-right:auto;">
        <thead>
            <tr>
                <th>Product ID</th>
                <th>Product Name</th>
                <th>Product Stock</th>
                <th>Product Type</th>
                <th>Product Quantity</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="rptProducts" OnItemDataBound="rptProducts_ItemDataBound">
                <ItemTemplate>
                    <tr>
                        <td><asp:Label runat="server" ID="lblProductID"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductName"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductStock"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductType"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductQuantity"></asp:Label></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    </div>  
</asp:Content>
