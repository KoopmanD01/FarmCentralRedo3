<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="FarmCentralRedo3.ForgotPassword" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <style>
   .boxS 
       {
            margin-top:70px;
            border-radius:30px;
            width: 350px;
            background-color: white;
       }
</style>

    <center> <h1>Forgot Password</h1><br><br><br>
        <div class="boxS">
                     <asp:Label class="errorLabel" id ="errorLabel" runat="server" ></asp:Label><br>
    
                         <asp:Label class="loginTextBox"  runat="server" Text="Unique ID:"></asp:Label><br>
                       <asp:TextBox class="loginTextBox" id="txtID" runat="server"></asp:TextBox><br><br>
  
                        <asp:Label class="loginTextBox"  runat="server" Text="Email:"></asp:Label><br>
                      <asp:TextBox class="loginTextBox" id="txtEmail" runat="server"></asp:TextBox><br><br>
    
                    <asp:Label class="loginTextBox"  runat="server" Text="New Password:"></asp:Label><br>
                        <input class="loginTextBox" id="txtNewPassword"  type="password"  runat="server"></input><br><br>

                    <asp:Label class="loginTextBox"  runat="server" Text="Confirm Password:"></asp:Label><br>
                    <input class="loginTextBox" id="txtConPassword" type="password"  runat="server"><br>

                    </input><asp:Label class="errorLabel" id ="invalidPassword" runat="server" ></asp:Label><br><br>

                    <asp:Button ID="buttonCreate" runat="server" Text="Create New Password" OnClick="buttonCreate_Click" /><br><br>
            </div>
        </center>
</asp:Content>
