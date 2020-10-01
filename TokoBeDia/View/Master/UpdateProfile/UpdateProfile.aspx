<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TokoBeDia.View.Master.UpdateProfile.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .error{
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" ID="lblUpdateProfiles"></asp:Label>
    <br />
    <asp:Button runat="server" ID="btnHome" OnClick="btnHome_Click" Text="Home" />
    <br />
    <br />
    <table border="1">
        <tbody>
            <tr>
                <th>Email</th>
                <td><asp:TextBox runat="server" ID="txtEmail"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Name</th>
                <td><asp:TextBox runat="server" ID="txtName"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Gender</th>
                <td>
                    <asp:DropDownList runat="server" ID="ddlGender">
                        <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                        <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </tbody>
    </table>
    <asp:Label CssClass="error" runat="server" ID="lblError" Text="All field must not be empty" Visible="false"></asp:Label>
    <br />
    <asp:Button runat="server" ID="btnUpdate" Text="Update Profile" OnClick="btnUpdate_Click" />
</asp:Content>
