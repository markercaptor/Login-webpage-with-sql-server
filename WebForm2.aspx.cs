using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace assignment4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //SqlConnection cnn = new SqlConnection(SqlDataSource1.ConnectionString);
            //SqlDataAdapter da = new SqlDataAdapter("select * from [User]", cnn);
            // DataSet ds = new DataSet();
            txtUser.Text = Session["User"].ToString();
            txtEmail.Text = Session["Email"].ToString();
            Label1.Visible = false;

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string value = txtFN.Text;
            string em = txtLN.Text;
            string ps = txtPass.Text;
            string dl = dlCountry.SelectedValue;


            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand cmd = new SqlCommand();
           
            
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT  [User] (User_FName,User_LName,User_Password, User_Country) VALUES('" + value+ "','" + em + "','" + ps + "','" + dl +"')";
            
            cmd.Connection = db;
           
            db.Open();
          

          

            try
            {
                cmd.ExecuteNonQuery();
                
                Label1.Text = "Succes writing into database!";
                Label1.Visible = true;
                Response.Redirect("WebForm3.aspx");

            }

            catch
            {
                Label1.Text = "An Error Occured Writing into Database!";
                Label1.Visible = true;

            }

            finally
            {
                db.Close();
              
            }

            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void CustomValidator7_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }

}



