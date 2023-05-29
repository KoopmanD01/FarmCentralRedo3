using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FarmCentralRedo3
{
   
    public partial class Login : System.Web.UI.Page
    {
        private FarmCentralRedo3.Employee MyTable;

        private string empId = "";
        private string empPass = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Add("userRole", "Employee");
        }

        public void GetData() 
        {
        
        
        
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                empId = this.txtEmployeeID.Text;
                empPass = this.txtPassword.Value;

                farmcentral02Entities db = new farmcentral02Entities();

                var d = db.Employees.Find(empId.ToString());
                {

                    if (d.employeeID.ToString().Equals(empId) && d.employeePassword.ToString().Equals(empPass))
                    {
                        Session.Add("userEmail", d.employeeEmail.ToString());
                        Session.Add("user", d.employeeID.ToString());
                        
                        Response.Redirect("~/EmpHomePage.aspx", false);

                    }
                    else
                    {
                        ErrorLabel.Text = "Invalid Credentials!";

                    }
                }

            }
            catch(Exception ex)
            {

            }
           
        }

       
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}