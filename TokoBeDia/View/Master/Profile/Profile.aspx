<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/General.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokoBeDia.View.Master.Profile.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .user{
            font-size: 50px;
            display: block;
            width:100%;
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" ID="UserProfile" CssClass="user"></asp:Label>
    <br />
    <asp:Button runat="server" ID="btnHome" OnClick="btnHome_Click" Text="Home" />
    <asp:Button runat="server" ID="btnUpdateProfile" OnClick="btnUpdateProfile_Click" Text="Update Profile" />
    <asp:Button runat="server" ID="btnReset" OnClick="btnReset_Click" Text="Change Password" />
    <br />
    <br />
    <table border="1" style="text-align:center; width:auto; margin-left:auto;margin-right:auto;">
        <thead>
            <tr>
                <th>Email</th>
                <th>Name</th>
                <th>Gender</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater runat="server" ID="rptProfile" OnItemDataBound="rptProfile_ItemDataBound">
                <ItemTemplate>
                    <tr>
                        <th><asp:Label runat="server" ID="lblEmail"></asp:Label></th>
                        <td><asp:Label runat="server" ID="lblName"></asp:Label></td>
                        <td><asp:Label runat="server" ID="lblGender"></asp:Label></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
