<%@ Page Language="C#" MasterPageFile="~/EmpLogged.Master" AutoEventWireup="true" CodeBehind="EmpViewData.aspx.cs" Inherits="FarmCentralRedo3.EmpViewData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <style>

       .boxS {
         border-radius:30px;
     width: 600px;
    background-color: white;
}
       .calLeft
{
 margin-left:50px;
    float:left;
       
}
.calRight {
    margin-right: 50px;
    float: right;
}
   </style>
    <center>
    <div class ="boxS">
         <center>
                <div class="boxS">
                        <div >
     
                               <h1>View Products</h1><br>
                               <asp:Label class="errorLabel" ID="ErrorLabel" runat="server" ></asp:Label> 
                               <h2 class="errorLabel">Choose Farmer:</h2>
                               <asp:DropDownList ID="DropDownProducts" runat="server"></asp:DropDownList>
                               <asp:Button  ID="SubmitButton" runat="server" Text="Search" OnClick="SubmitButton_Click"></asp:Button>

                        </div>
               </div>
           </center>
     
              <br>
                         <asp:Label class ="calLeft" ID="StartLabel" runat="server" Text="Start Date"></asp:Label>
                         <asp:Label class="calRight" ID="EndLabel" runat="server" Text="End Date"></asp:Label><br>
                         <asp:Label class ="calLeft" ID="txtStartdate" runat="server"></asp:Label> 
                         <asp:Label class="calRight" ID="txtEndDate" runat="server"></asp:Label><br>

                         <asp:Calendar class="calLeft" ID="startCalendar" runat="server" OnSelectionChanged="startCalendar_SelectionChanged" ></asp:Calendar> 
                         <asp:Calendar class="calRight" ID="endCalendar" runat="server" OnSelectionChanged="endCalendar_SelectionChanged" ></asp:Calendar><br><br><br><br><br><br><br><br><br><br>

                   <div>

                                <asp:Button  class="calLeft"  ID="viewAll" runat="server" Text="View All" OnClick="viewAll_Click" ></asp:Button>
                       <div class="calRight">
                           <asp:Label  runat="server" Text="Category"></asp:Label>
                               <asp:DropDownList  ID="DropDownCategory" runat="server"></asp:DropDownList>
                               <asp:Button ID="CategorySearch" runat="server" Text="Search" OnClick="CategorySearch_Click" ></asp:Button><br>
                       </div>
                                

                   </div>  <br><br>
          </div>     
        <br><br>
        <center> 
            <div >
           <table >
                
                <tr>


                    <td>
                        <asp:GridView  ID="GridView2" runat="server"></asp:GridView>

                    </td>
                </tr>



            </table>

        </div> 
           </center>
        
   
    </center>
    
</asp:Content>
