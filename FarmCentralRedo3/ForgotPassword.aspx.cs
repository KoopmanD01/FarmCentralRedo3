using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FarmCentralRedo3
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected void Page_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }



        public void getID() 
        {
            try
            {
                if (txtID.Text == "" || txtEmail.Text == "" || txtNewPassword.Value == "" || txtConPassword.Value == "" )
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Fill in All fields";
                }
                else
                {

                    string ID = txtID.Text.ToString();
                    string pass = txtNewPassword.Value.ToString();
                    string conPass = txtNewPassword.Value.ToString();
                    string Email = txtEmail.Text.ToString();
                    string role = Session["userRole"].ToString();

                    if (pass.Equals(conPass))
                    {
                        if (role.Equals("Employee"))
                        {
                            farmcentral02Entities db = new farmcentral02Entities();
                            var d = db.Employees.Find(ID);

                            if(d != null)
                            {
                                SqlConnection connection = new SqlConnection(ConnectionString);
                                string con1 = "UPDATE Employee SET employeePassword = '" + pass + "' WHERE employeeID = '" + ID + "' ;";
                                SqlCommand command = new SqlCommand(con1, connection);
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                Session["userEmail"] = Email;

                                txtID.Text = "";
                                txtEmail.Text = "";
                                txtNewPassword.Value = "";
                                txtConPassword.Value = "";
                                Response.Redirect("~/EmployeeLog.aspx", false);

                            }
                            else
                            {

                                errorLabel.Text = "Invalid ID";
                            }
                         
                        }
                        else if(role.Equals("Farmer"))
                        {
                            farmcentral02Entities db = new farmcentral02Entities();
                            var d = db.Farmers.Find(ID);
                            if (d != null)
                            {
                                SqlConnection connection = new SqlConnection(ConnectionString);
                                string con1 = "UPDATE Farmer SET farmerPassword = '" + pass + "' WHERE farmerID = '" + ID + "' ;";
                                SqlCommand command = new SqlCommand(con1, connection);
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                Session["userEmail"] = Email;

                                txtID.Text = "";
                                txtEmail.Text = "";
                                txtNewPassword.Value = "";
                                txtConPassword.Value = "";
                                Response.Redirect("~/FarmerLog.aspx", false);

                            }
                            else
                            {

                                errorLabel.Text = "Invalid ID";
                            }
                           
                        }
                       

                    }
                    else
                    {
                        invalidPassword.Text = "Passwords dont match!";
                    }

                    
                }


            }
            catch (Exception ex)
            {


            }
        }

        protected void buttonCreate_Click(object sender, EventArgs e)
        {
            getID();
        }
    }
}