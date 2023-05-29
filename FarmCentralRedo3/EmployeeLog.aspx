<%@ Page Title="EmployeeLogin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeLog.aspx.cs" Inherits="FarmCentralRedo3.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <style>

       .boxS {
           margin-top:70px;
         border-radius:30px;
     width: 350px;
    background-color: white;
}
   </style>
       
        <center>
            <h1 class ="jumbotron">Employee Credentials</h1><br><br>
            <div class ="boxS">
            
                <asp:Label class="errorLabel" ID="ErrorLabel" runat="server" ></asp:Label> </> <br><br>
                <asp:TextBox class="loginTextBox" id="txtEmployeeID" name="txtemployeeId" placeholder="Employee ID" runat="server"></asp:TextBox><br><br>
                <input class="loginTextBox" id="txtPassword" name="txtPassword" type="password" placeholder="Password" runat="server"></input><br><br>
           
         
                <asp:Button  ID="SubmitButton" runat="server" Text="SUBMIT" OnClick="SubmitButton_Click" /><br><br>
                 <a class="forgotPasText" runat="server" href="~/ForgotPassword">Forgot Password</a>
                </div>
        </center>
    
    
    
</asp:Content>

