<%@ Page Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="SignupPage.aspx.cs" Inherits="OnlineShoppingWeb.SignupPage" %>

<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head"></asp:Content>
<asp:Content ID="contentPlaceHolderSignIn" runat="server" ContentPlaceHolderID="ContentPlaceHolder">
    <link rel="stylesheet" href="OnlineShoppingDesign.css" />
        <h1 style="text-align: center">Create Account</h1>
        <table class="center">
            <p style="text-align:center">SIGNUP</p>
            <br />
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox runat="server" ID="name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Validatorname" runat="server" ErrorMessage="Name is Required" ForeColor="Blue" ControlToValidate="name">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobile Number</td>
                <td>
                    <asp:TextBox runat="server" ID="mobile"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RValidatorMobile" runat="server" ErrorMessage="Mobile Number is Required"
                        ForeColor="Blue" ControlToValidate="mobile">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorMobile" runat="server" ControlToValidate="mobile" ErrorMessage="Enter Correct Mobile Number"
                        ForeColor="Red" ValidationExpression="[9876]\d{9}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>E-Mail Id</td>
                <td>
                    <asp:TextBox runat="server" ID="email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidatorEmail" runat="server" ErrorMessage="EmailId is Required"
                        ForeColor="Blue" ControlToValidate="email">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="email" ErrorMessage="Enter Correct E-Mail format"
                        ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox runat="server" ID="password" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidatorPassword" runat="server" ErrorMessage="Password is Required" ForeColor="Blue" ControlToValidate="password">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorPassword" runat="server" ControlToValidate="password" ErrorMessage="Enter Correct Password Format"
                        ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Conform Password</td>
                <td>
                    <asp:TextBox runat="server" ID="repassword" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidatorConformPassword" runat="server" ErrorMessage="Conform Password is Required" ForeColor="Blue" ControlToValidate="repassword">
                    </asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                        ControlToCompare="password" ControlToValidate="repassword" ForeColor="Red" ErrorMessage="Password does not Match">
                    </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button runat="server" ID="signup" Text="Submit" align="Center" OnClick="Registration_Click" /></td>
            </tr>
        </table>
</asp:Content>
