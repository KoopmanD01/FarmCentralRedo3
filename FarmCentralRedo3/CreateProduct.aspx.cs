using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FarmCentralRedo3
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        string userID = "";
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Session["user"].ToString();
          
            farmcentral02Entities db = new farmcentral02Entities();

            var d = db.Farmers.Find(userID);

            string farmerEm = d.farmerEmail.ToString();
           

            farmerIDLabel.Text = userID;
         
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------


        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (txtproductName.Text == "" || txtproductCategory.Text =="" || txtproductPrice.Value =="" || txtproductDate.Value =="")
            {
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text = "Not all fields were completed";
            }
            else
            {
                AddData();
                txtproductName.Text = "";
                txtproductCategory.Text = "";
                txtproductPrice.Value = "";
                txtproductDate.Value = "";
                ErrorLabel.Text = "";

            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        public void AddData()
        {
            try
            {
                string d = "";
                d = txtproductPrice.Value;
                double number = Double.Parse(d);

                string date = txtproductDate.Value;
                SqlConnection connection = new SqlConnection(ConnectionString);
                string con1 = "INSERT INTO Product VALUES('" + txtproductName.Text + "','" + txtproductCategory.Text + "'," + number + ",'" + date + "','" + userID + "');";
                SqlCommand command = new SqlCommand(con1, connection);
                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch(Exception ex)
            {

            }

           

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------


    }
}