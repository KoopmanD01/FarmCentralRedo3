<%@ Page Title="Create Farmer" Language="C#"MasterPageFile="~/EmpLogged.Master" AutoEventWireup="true" CodeBehind="CreateFarmer.aspx.cs" Inherits="FarmCentralRedo3.CreateFarmer" %>

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
             <center>
                   <h1>Create Farmer</h1><br>
                                 <div class="boxS" ><br>
                                    <asp:Label class="errorLabel" ID="ErrorLabel" runat="server" ></asp:Label> <br><br>
                                    <asp:TextBox class="loginTextBox" id="txtfarmerID" name="txtFarmerID" placeholder="Farmer ID" runat="server"></asp:TextBox><br><br>
                                    <asp:TextBox class="loginTextBox" id="txtfarmerName" name="txtFarmerName" placeholder="Farmer Name" runat="server"></asp:TextBox><br><br>
                                    <asp:TextBox class="loginTextBox" id="txtfarmerLocation" name="txtFarmerLocation" placeholder="Farmer Location" runat="server"></asp:TextBox><br><br>
                                    <asp:TextBox class="loginTextBox" id="txtfarmerNumber" name="txtFarmerNumber" placeholder="Farmer Number" runat="server"></asp:TextBox><br><br>
                                    <asp:TextBox class="loginTextBox" id="txtfarmerEmail" name="txtFarmerEmail" placeholder="Farmer Email" runat="server"></asp:TextBox><br><br>
                                    <input class="loginTextBox" id="txtPassword" name="txtPassword" type="password" placeholder="Farmer Password" runat="server"></input><br><br>
      
                         
                                    <asp:Button  ID="SubmitButton" runat="server" Text="Create Farmer" OnClick="SubmitButton_Click" /><br><br>
                 
                                 </div>               
              </center> 
        
</asp:Content>
