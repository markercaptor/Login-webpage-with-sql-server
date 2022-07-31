using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["User"]= Username.Text;
            Session["Email"] = Useremail.Text;
            string value = Username.Text;
            string em = Useremail.Text;

            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand cmd = new SqlCommand();
         
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT  [User] (User_Username,User_Email) VALUES('" + value  +"', '"+ em + "')";
         
            cmd.Connection = db;
         
            db.Open();
            SqlConnection conn2 = new SqlConnection(SqlDataSource1.ConnectionString);
            conn2.Open();
            SqlCommand search = new SqlCommand("SELECT (User_Username) FROM [User] WHERE User_Username= @Username", conn2);
            search.Parameters.AddWithValue("@Username", value.ToString());
            SqlDataReader scan = search.ExecuteReader();

            if (scan.HasRows)
            {
                Label2.Text = "Username is Taken!";
                Label2.Visible = true;
            }
            else
            {
                Label2.Text = "Username is Available!";
                Label2.Visible = true;
                try { }
                catch { }
                finally { }
                Response.Redirect("WebForm2.aspx");
            }

            try
             {
                 cmd.ExecuteNonQuery();
                
               //  Label1.Text = "Success writing into database!"; 
                // Label1.Visible = true;
                

            }

             catch
             {
                // Label1.Text = "An Error Occured Writing into Database!";
                 //Label1.Visible = true;

             }

             finally
             {
                 db.Close(); 
               
             }

           
        }


       
    }
}