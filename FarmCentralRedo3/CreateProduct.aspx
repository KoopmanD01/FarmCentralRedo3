<%@ Page Language="C#" MasterPageFile="~/FarmLogged.Master" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="FarmCentralRedo3.CreateProduct" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
   <style>

       .boxS {
           margin-top:70px;
         border-radius:30px;
     width: 350px;
    background-color: white;
}
   </style>
     

          <center >
              
                 <h1>Create Product</h1><br>
              <div class ="boxS"><br>  
                     <asp:Label class="errorLabel" ID="ErrorLabel" runat="server" ></asp:Label><br><br>  

                    <asp:TextBox class="loginTextBox" id="txtproductName" name="txtProductName" placeholder="Product Name" runat="server"></asp:TextBox><br><br>
                    <asp:TextBox class="loginTextBox" id="txtproductCategory" name="txtProductCategory" placeholder="Product Category" runat="server"></asp:TextBox><br><br>
                    <input class="loginTextBox" id="txtproductPrice" name="txtProductPrice" type="number" placeholder="Product Price" runat="server"></input><br><br>
                    <input class="loginTextBox" id="txtproductDate" name="txtProductDate" type="date" placeholder="Date" runat="server"></input><br><br>              
                    <asp:Label ID="farmerIDLabel" runat="server" ></asp:Label><br><br>

                    <asp:Button  ID="SubmitButton" runat="server" Text="Create Product" OnClick="SubmitButton_Click" /><br><br>
                 
                    
            </div>
          </center>
        
        
</asp:Content>
