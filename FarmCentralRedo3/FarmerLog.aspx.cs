using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FarmCentralRedo3
{
    public partial class Farmer : System.Web.UI.Page
    {
        private FarmCentralRedo3.Employee MyTable;
        private string farmerEm = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Add("userRole", "Farmer");

        }

        public void GetData()
        {
            


        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                farmcentral02Entities db = new farmcentral02Entities();

                var d = db.Farmers.Find(txtfarmerID.Text);

                if (d.farmerID.ToString().Equals(txtfarmerID.Text.ToString()) && d.farmerPassword.ToString().Equals(txtPassword.Value.ToString()))
                {
                    Session.Add("userEmail", d.farmerEmail.ToString());
                    Session.Add("user", d.farmerID.ToString());
                    
                    Response.Redirect("~/FarmHomePage.aspx");
                }
                else
                {
                    ErrorLabel.Text = "Invalid Credentials!";

                }
            }
            catch(Exception ex)
            {

            }
           
            
        }

        
    }
}