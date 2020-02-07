<%@ Page Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="OnlineShoppingWeb.WebForm1" %>

<asp:content id="contentHead" runat="server" contentplaceholderid="head"></asp:content>
<asp:content id="contentPlaceHolderSignIn" runat="server" contentplaceholderid="ContentPlaceHolder">
    <link rel="stylesheet" href="OnlineShoppingDesign.css" />
<table class="center">
    <p style="text-align: center">LOGIN PAGE</p>
    <tr>
        <td>Username</td>
        <td class="place">
            <asp:textbox runat="server" id="Username" ></asp:textbox>
        </td>
    </tr>
    <tr>
        <td>Password</td>
        <td>
            <asp:textbox runat="server" id="Password" textmode="Password"></asp:textbox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:button runat="server" id="Signup" text="SignUp" onclick="Signup_Click" />
        </td>
        <td>
            <asp:button runat="server" id="Sumbit" text="Login" onclick="Login_Click" />
        </td>
    </tr>
</table>
</asp:content>
