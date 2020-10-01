<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="TokoBeDia.View.Master.InsertProduct.InsertProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .error{
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Product</h1>
    <asp:Button runat="server" OnClick="btnLogin_Click" ID="btnLogin" Text="Home" />
    <table border="1">
        <tbody>
            <tr>
                <th>Product Name</th>
                <td><asp:TextBox runat="server" ID="txtProductName"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Stock</th>
                <td><asp:TextBox runat="server" ID="txtStock" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Product Type</th>
                <td><asp:DropDownList runat="server" ID="ddlProductType"></asp:DropDownList></td>
            </tr>
            <tr>
                <th>Price</th>
                <td><asp:TextBox runat="server" ID="txtPrice" TextMode="Number"></asp:TextBox></td>
            </tr>
        </tbody>
    </table>
    <br />
    <asp:Label CssClass="error" runat="server" ID="lblError" Text="All field must not be empty" Visible="false"></asp:Label>
    <br />
    <asp:Button runat="server" ID="btnInsert" Text="Insert Product" OnClick="btnInsert_Click" />
</asp:Content>
