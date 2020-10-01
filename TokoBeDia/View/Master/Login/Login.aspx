<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TokoBeDia.View.Master.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .error{
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server">Email</asp:Label><br />
        <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
        <br />

        <asp:Label runat="server">Password</asp:Label><br />
        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
        <br />

        <asp:CheckBox runat="server" ID="cbxRememberme" Text="Remember Me" />
        <br />
        <asp:Label CssClass="error" runat="server" ID="lblError" Text="All field must not be empty" Visible="false"></asp:Label>
        <asp:Label CssClass="error" runat="server" ID="lblUserError" Text="User doesn't exists" Visible="false"></asp:Label>
        <asp:Label CssClass="error" runat="server" ID="lblPasswordError" Text="Wrong Password" Visible="false"></asp:Label>
        <br />
        <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button runat="server" ID="btnRegister" Text="Register" OnClick="btnRegister_Click" />
        <asp:Button runat="server" ID="btnHome" Text="Home" OnClick="btnHome_Click" />
    </div>
</asp:Content>
