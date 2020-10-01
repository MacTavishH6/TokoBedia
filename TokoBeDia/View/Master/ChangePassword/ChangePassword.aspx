<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="TokoBeDia.View.Master.ChangePassword.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .error{
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Change Password</h1>
    <br />
    <asp:Button runat="server" ID="lblHome" Text="Home" OnClick="lblHome_Click" />
    <br />
    <table>
        <tr>
            <th>Old Password</th>
            <td><asp:TextBox runat="server" ID="txtOldPassword"></asp:TextBox></td>
        </tr>
        <tr>
            <th>New Password</th>
            <td><asp:TextBox runat="server" ID="txtNewPassword"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Confirm Password</th>
            <td><asp:TextBox runat="server" ID="txtConfirmPassword"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Label CssClass="error" runat="server" ID="lblConfirmError" Text="Confirm Password must be same with New Password" Visible="false"></asp:Label>
    <asp:Label CssClass="error" runat="server" ID="lblOldPasswordError" Text="Wrong Old Password" Visible="false"></asp:Label>
    <asp:Label CssClass="error" runat="server" ID="lblError" Text="All field must not be empty" Visible="false"></asp:Label>
    <br />
    <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click"/>
</asp:Content>
