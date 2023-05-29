<%@ Page Language="C#" MasterPageFile="~/FarmLogged.Master" AutoEventWireup="true" CodeBehind="FarmProfile.aspx.cs" Inherits="FarmCentralRedo3.FarmProfile" %>

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
        <h1>Profile</h1><br>
            <div class="boxS"><br>
                <asp:Label ID="errorLabel" class="loginTextBox"  runat="server"></asp:Label><br><br>

                <asp:Label class="loginTextBox"  runat="server" Text="Farmer Name:"></asp:Label><br>
                <asp:Label id="labelName" class="loginTextBox"  runat="server" ></asp:Label><br>
                  <asp:TextBox class="loginTextBox" id="txtfarmerName" runat="server"></asp:TextBox><br><br>

                <asp:Label class="loginTextBox"  runat="server" Text="Farmer Location:"></asp:Label><br>
                <asp:Label id="labelLocation" class="loginTextBox"  runat="server" ></asp:Label><br>
                  <asp:TextBox class="loginTextBox" id="txtfarmerLocation" runat="server"></asp:TextBox><br><br>

                  <asp:Label class="loginTextBox"  runat="server" Text="Farmer Number:"></asp:Label><br>
                <asp:Label id="labelNumber" class="loginTextBox"  runat="server" ></asp:Label><br>
                  <asp:TextBox class="loginTextBox" id="txtfarmerNumber" runat="server"></asp:TextBox><br><br>

                  <asp:Label class="loginTextBox"  runat="server" Text="Farmer Email:"></asp:Label><br>
                <asp:Label id="labelEmail" class="loginTextBox"  runat="server" ></asp:Label><br>
                  <asp:TextBox class="loginTextBox" id="txtfarmerEmail" runat="server"></asp:TextBox><br><br>
                <asp:Button ID="updateButton" runat="server" Text="Update Profile" OnClick="updateButton_Click" /><br><br>
            </div>
      </center>
</asp:Content>
