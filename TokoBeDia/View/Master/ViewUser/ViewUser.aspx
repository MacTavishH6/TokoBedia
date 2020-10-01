<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBeDia.View.Master.ViewUser.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>View User</h1>
    <asp:Button runat="server" ID="btnHome" OnClick="btnHome_Click" Text="Home" />
    <br />
    <table border="1">
        <thead>
            <tr>
                <th>UserID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Role</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="rptUser" OnItemDataBound="rptUser_ItemDataBound">
                <ItemTemplate>
                    <tr>
                        <td><asp:Label runat="server" ID="lblUserID"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblName"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblEmail"></asp:Label></td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlRole" OnSelectedIndexChanged="ddlRole_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlStatus" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Value="D" Text="Banned"></asp:ListItem>
                                <asp:ListItem Value="A" Text="Active"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
