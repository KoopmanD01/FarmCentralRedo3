using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FarmCentralRedo3
{
    public partial class CreateFarmer : System.Web.UI.Page
    {
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (txtfarmerID.Text == "" || txtfarmerName.Text == "" || txtfarmerLocation.Text == "" ||txtfarmerNumber.Text=="" || txtfarmerEmail.Text == "" || txtPassword.Value =="")
            {
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text = "Not all fields were completed";
            }
            else
            {
                AddData();
                txtfarmerID.Text = "";
                txtfarmerName.Text = "";
                txtfarmerNumber.Text = "";
                txtfarmerLocation.Text = "";
                txtfarmerEmail.Text = "";
                ErrorLabel.Text = "";
            }
        
        }

        public void AddData() 
        {
            try
            {
                int number = int.Parse(txtfarmerNumber.Text); ;
                string password = txtPassword.Value.ToString();
                SqlConnection connection = new SqlConnection(ConnectionString);
                string con1 = "INSERT INTO Farmer VALUES('" + txtfarmerID.Text + "','" + txtfarmerName.Text + "','" + txtfarmerLocation.Text + "'," + number + ",'" + txtfarmerEmail.Text + "','" + password + "');";
                SqlCommand command = new SqlCommand(con1, connection);
                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {

            }
            
        }

        

    }
}