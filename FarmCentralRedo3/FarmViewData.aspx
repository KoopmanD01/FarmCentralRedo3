<%@ Page Language="C#" MasterPageFile="~/FarmLogged.Master" AutoEventWireup="true" CodeBehind="FarmViewData.aspx.cs" Inherits="FarmCentralRedo3.FarmViewData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>Products</h1>
    </center>
    <br><br><br><br><br><br><br><br><br>
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
    
</asp:Content>
