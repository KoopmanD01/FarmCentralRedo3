using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentralRedo3
{
    public partial class EmpProfile : System.Web.UI.Page
    {
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string user = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           farmcentral02Entities db = new farmcentral02Entities();
            user = Session["user"].ToString();
            var d = db.Employees.Find(Session["user"].ToString());

            labelID.Text = d.employeeID.ToString();
            labelName.Text = d.employeeName.ToString();
            labelSurname.Text = d.employeeSurname.ToString();
            labelEmail.Text = d.employeeEmail.ToString();
            
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
            
                if(txtemployeeName.Text == "" || txtemployeeSurname.Text == ""|| txtemployeeEmail.Text == "")
                {

                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Fill in All fields";

                }
                else
                {
                    string Name = txtemployeeName.Text.ToString();
                    string Surname = txtemployeeSurname.Text.ToString();
                    string Email = txtemployeeEmail.Text.ToString();

                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string con1 = "UPDATE Employee SET employeeName = '" + Name + "', employeeSurname = '" + Surname + "', employeeEmail = '" + Email + "' WHERE employeeID = '" + user + "' ;";
                    SqlCommand command = new SqlCommand(con1, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    Session["userEmail"] = Email;

                    txtemployeeName.Text = "";
                    txtemployeeSurname.Text = "";
                    txtemployeeEmail.Text = "";
                }
                

            }
            catch (Exception ex)
            {


            }
        }
    }
}