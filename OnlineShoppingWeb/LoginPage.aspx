<%@ Page Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs"
    Inherits="OnlineShoppingWeb.WebForm1" Trace="false" %>

<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head"></asp:Content>
<asp:Content ID="contentPlaceHolderSignIn" runat="server" ContentPlaceHolderID="ContentPlaceHolder">
    <link rel="stylesheet" href="OnlineShoppingDesign.css" />
    <body>
        <table class="center">
            <p style="text-align: center">LOGIN PAGE</p>
            <tr>
                <td>Username</td>
                <td class="place">
                    <asp:TextBox runat="server" ID="Username"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldUsername" runat="server" ErrorMessage="Username is Required" ForeColor="Blue" 
                        ControlToValidate="Username" ValidationGroup="ValidLogin">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ErrorMessage="Password is Required" ForeColor="Blue" 
                        ControlToValidate="Password" ValidationGroup="ValidLogin">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <asp:Panel ID="DefaultLogin" runat="server" DefaultButton="Sumbit">
                    <td>
                        <asp:Button runat="server" ID="Signup" Text="SignUp" OnClick="Signup_Click" />
                    </td>
                    <td>
                        <asp:Button runat="server" ID="Sumbit" Text="Login" OnClick="Login_Click" ValidationGroup="ValidLogin"/>
                    </td>
                </asp:Panel>

            </tr>
        </table>
    </body>
</asp:Content>
