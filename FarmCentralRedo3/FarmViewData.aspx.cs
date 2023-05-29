using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentralRedo3
{

    public partial class FarmViewData : System.Web.UI.Page
    {
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                GridView2.BackColor = System.Drawing.Color.White;
                SqlConnection connection = new SqlConnection(ConnectionString);
                string con1 = "SELECT productID,productName,productCategory,productPrice,productDate FROM Product WHERE farmerID = '" + Session["user"].ToString() + "';";
                SqlCommand command = new SqlCommand(con1, connection);
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                GridView2.DataSource = dt;
                GridView2.DataBind();
                connection.Close();

            }
            catch(Exception ex)
            {


            }
            
        }
    }
}