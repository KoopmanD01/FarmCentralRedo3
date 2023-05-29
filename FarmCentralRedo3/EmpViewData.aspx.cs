using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentralRedo3
{
    public partial class EmpViewData : System.Web.UI.Page
    {
        private string ConnectionString = "Server=tcp:st10081776fc.database.windows.net,1433;Initial Catalog=farmcentral02;Persist Security Info=False;User ID=st10081776;Password=COREmeal37;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private string userSearch = "";
        
        
        
        //----------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ErrorLabel.ForeColor = System.Drawing.Color.Red;
            startCalendar.BackColor = System.Drawing.Color.White;
            
            endCalendar.BackColor = System.Drawing.Color.White;
           
            GridView2.BackColor = System.Drawing.Color.White;
            
            if(DropDownProducts.Items.Count == 0 ) 
            {
                getID();
            }
            
            foreach (DataControlField column in GridView2.Columns)
            {
                column.ItemStyle.Width = Unit.Pixel(400);
            }

            
        }
             
        //----------------------------------------------------------------------------------------------------------------------------------------
        protected void SubmitButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtStartdate.Text.Equals("") || txtEndDate.Text.Equals(""))
                {
                    ErrorLabel.Text = "Please select date range";

                }
                else
                {
                    ErrorLabel.Text = "";
                    string id = DropDownProducts.Text.ToString();

                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string con1 = "SELECT * FROM Product WHERE farmerID = '" + id + "' AND productDate between '" + txtStartdate.Text + "' and '" + txtEndDate.Text + "';";
                    SqlCommand command = new SqlCommand(con1, connection);
                    connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                    connection.Close();
                    DropDownProducts.Items.Clear();
                    DropDownCategory.Items.Clear();
                    getID();

                }
            }
            catch(Exception ex)
            {


            }
          
           
            

        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        private void getID()
        {

            farmcentral02Entities db = new farmcentral02Entities();
            foreach (var c in db.Products)
            {
                DropDownCategory.Items.Add(c.productCategory.ToString());
            }

            foreach (var d in db.Farmers)
            {
                DropDownProducts.Items.Add(d.farmerID.ToString());
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        protected void viewAll_Click(object sender, EventArgs e)
        {
            try
            {
                StartLabel.Text = "";
                EndLabel.Text = "";

                txtStartdate.Text = "";
                txtEndDate.Text = "";
                string id = DropDownProducts.Text.ToString();

                SqlConnection connection = new SqlConnection(ConnectionString);
                string con1 = "SELECT * FROM Product; ";
                SqlCommand command = new SqlCommand(con1, connection);
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                GridView2.DataSource = dt;
                GridView2.DataBind();
                connection.Close();
                DropDownProducts.Items.Clear();
                DropDownCategory.Items.Clear();
                getID();


            }
            catch (Exception ex)
            {


            }
       
            
           
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        protected void startCalendar_SelectionChanged(object sender, EventArgs e)
        {
            txtStartdate.Text = startCalendar.SelectedDate.ToString("yyyy.MM.dd");
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        protected void endCalendar_SelectionChanged(object sender, EventArgs e)
        {
            txtEndDate.Text = endCalendar.SelectedDate.ToString("yyyy.MM.dd");
        }

        protected void CategorySearch_Click(object sender, EventArgs e)
        {
            try
            {
                StartLabel.Text = "";
                EndLabel.Text = "";

                txtStartdate.Text = "";
                txtEndDate.Text = "";

                string category = DropDownCategory.Text.ToString();

                SqlConnection connection = new SqlConnection(ConnectionString);
                string con1 = "SELECT * FROM Product WHERE productCategory = '" + category + "';";
                SqlCommand command = new SqlCommand(con1, connection);
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                GridView2.DataSource = dt;
                GridView2.DataBind();
                connection.Close();
                DropDownProducts.Items.Clear();
                DropDownCategory.Items.Clear();
                getID();

            }
            catch(Exception ex)
            {


            }
            

        }




        //----------------------------------------------------------------------------------------------------------------------------------------

    }
}