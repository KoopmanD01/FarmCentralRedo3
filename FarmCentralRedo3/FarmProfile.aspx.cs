using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentralRedo3
{
    public partial class FarmProfile : System.Web.UI.Page
    {
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private int phoneNum = 0;
        string user = "";


        protected void Page_Load(object sender, EventArgs e)
        {

            farmcentral02Entities db = new farmcentral02Entities();

            var d = db.Farmers.Find(Session["user"].ToString());
             user = Session["user"].ToString();

            labelName.Text = d.farmerName.ToString();
            labelLocation.Text = d.farmerLocation.ToString();
           labelNumber.Text = d.farmerNumber.ToString();
            labelEmail.Text = d.farmerEmail.ToString();
            
           
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfarmerName.Text == ""|| txtfarmerLocation.Text == "" || txtfarmerEmail.Text == "" || txtfarmerNumber.Text == "")
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Fill in All fields";
                }
                else
                {

                    string Name = txtfarmerName.Text.ToString();
                    string Location = txtfarmerLocation.Text.ToString();
                    string Email = txtfarmerEmail.Text.ToString();

                    phoneNum = int.Parse(txtfarmerNumber.Text);


                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string con1 = "UPDATE Farmer SET farmerName = '" + Name + "', farmerLocation = '" + Location + "', farmerNumber =" + phoneNum + ",farmerEmail = '" + Email + "' WHERE farmerID = '" + user + "' ;";
                    SqlCommand command = new SqlCommand(con1, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    Session["userEmail"] = Email;

                    txtfarmerName.Text = "";
                    txtfarmerLocation.Text = "";
                    txtfarmerEmail.Text = "";
                    txtfarmerNumber.Text = "";
                }
                
              
            }
            catch (Exception ex)
            {


            }
           



        }
       
    }
}