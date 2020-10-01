<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="TokoBeDia.View.Master.UpdateProductType.UpdateProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .error{
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Product Type</h1>
    <asp:Button runat="server" OnClick="btnLogin_Click" ID="btnLogin" Text="Home" />
    <table border="1">
        <tbody>
            <tr>
                <th>Product Type</th>
                <td><asp:TextBox runat="server" ID="txtProductType"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Description</th>
                <td><asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine" Columns="25" Rows="10"></asp:TextBox></td>
            </tr>
        </tbody>
    </table>
    <br />
    <asp:Label CssClass="error" runat="server" ID="lblError" Text="All field must not be empty" Visible="false"></asp:Label>
    <br />
    <asp:Button runat="server" ID="btnInsert" Text="Update Product Type" OnClick="btnInsert_Click" />
</asp:Content>
