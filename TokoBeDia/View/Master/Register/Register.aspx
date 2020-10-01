<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TokoBeDia.View.Master.Register.Register" %>
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

        <asp:Label runat="server">Name</asp:Label><br />
        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
        <br />

        <asp:Label runat="server">Password</asp:Label><br />
        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label runat="server">Confirm Password</asp:Label><br />
        <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password"></asp:TextBox>
        <asp:Label CssClass="error" runat="server" ID="lblPasswordError" Text="Password not equals" Visible="false"></asp:Label>
        <br />

        <asp:Label runat="server">Gender</asp:Label><br />
        <asp:DropDownList runat="server" ID="ddlGender">
            <asp:ListItem Value="" Text="Choose One.." Enabled="true"></asp:ListItem>
            <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label CssClass="error" runat="server" ID="lblError" Text="All field must not be empty" Visible="false"></asp:Label>
        <br />
        <asp:Button runat="server" ID="btnRegister" Text="Register" OnClick="btnRegister_Click" />
        <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button runat="server" ID="btnHome" Text="Home" OnClick="btnHome_Click" />
       </div>
</asp:Content>
