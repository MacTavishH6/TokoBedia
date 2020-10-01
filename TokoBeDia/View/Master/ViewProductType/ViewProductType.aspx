<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="TokoBeDia.View.Master.ViewProductType.ViewProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center; width:auto; margin-left:auto;margin-right:auto;">View Products</h1>
    <br />
    <asp:Button runat="server" OnClick="btnHome_Click" ID="btnHome" Text="Home" />
    <br />
    <br />
    <asp:Button runat="server" ID="btnInsertProductType" Text="Insert Product Type" OnClick="btnInsertProductType_Click1"/>
    <table border="1" style="text-align:center; width:auto; margin-left:auto;margin-right:auto;">
        <thead>
            <tr>
                <th>Product ID</th>
                <th>Product Type</th>
                <th>Description</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="rptProducts" OnItemDataBound="rptProducts_ItemDataBound" OnItemCommand="rptProducts_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <td><asp:Label runat="server" ID="lblProductTypeID"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblProductType"></asp:Label></td>
                        <td><asp:TextBox id="txtDesc" ReadOnly="true" TextMode="multiline" Columns="40" Rows="5" runat="server" /></td>
                        <td>
                            <asp:Button runat="server" ID="lbUpdate" Text="Update" CommandName="Update"></asp:Button>
                            <asp:Button runat="server" ID="lbDelete" Text="Delete" CommandName="Delete"></asp:Button>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
