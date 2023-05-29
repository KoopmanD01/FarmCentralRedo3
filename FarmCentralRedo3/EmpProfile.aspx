<%@ Page Language="C#" MasterPageFile="~/EmpLogged.Master" AutoEventWireup="true" CodeBehind="EmpProfile.aspx.cs" Inherits="FarmCentralRedo3.EmpProfile" %>

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
        <h1>Profile</h1><br><br>
         <div class ="boxS"><br>
              <asp:Label ID="errorLabel" class="loginTextBox"  runat="server"></asp:Label><br><br>
          <asp:Label class="loginTextBox"  runat="server" Text="Employee ID:"></asp:Label><br>
         <asp:Label id ="labelID" class="loginTextBox"  runat="server" ></asp:Label><br><br>
          
        <asp:Label class="loginTextBox"  runat="server" Text="Employee Name:"></asp:Label><br>
         <asp:Label ID="labelName" class="loginTextBox"  runat="server" ></asp:Label><br>
          <asp:TextBox class="loginTextBox" id="txtemployeeName" runat="server"></asp:TextBox><br><br>

        <asp:Label class="loginTextBox"  runat="server" Text="Employee Surname:"></asp:Label><br>
         <asp:Label ID="labelSurname" class="loginTextBox"  runat="server"></asp:Label><br>
          <asp:TextBox class="loginTextBox" id="txtemployeeSurname" runat="server"></asp:TextBox><br><br>

          <asp:Label class="loginTextBox"  runat="server" Text="Employee Email:"></asp:Label><br>
         <asp:Label ID="labelEmail" class="loginTextBox"  runat="server" ></asp:Label><br>
          <asp:TextBox class="loginTextBox" id="txtemployeeEmail" runat="server"></asp:TextBox><br><br>

         <asp:Button ID="updateButton" runat="server" Text="Update Profile" OnClick="updateButton_Click" /><br><br>
             </div>
      </center>
    
</asp:Content>
