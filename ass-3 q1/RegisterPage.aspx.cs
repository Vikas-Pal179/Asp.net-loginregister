using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace ass_3_q1
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        string connectionStr = "Server=DESKTOP-RC1CAM9;Database=loginRegister;Trusted_Connection=True;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string txtUserName = userName.Text;
            string txtEmail = email.Text;
            string txtPass = password.Text;
            string txtConfirmPass = confirmPassword.Text;

            SqlConnection objConnection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConnection;
            cmd.CommandText = "insert into register values('"+txtUserName+"','"+txtEmail+"','"+txtPass+"')";
            
            objConnection.Open();   
            int res = cmd.ExecuteNonQuery();
            objConnection.Close();
            cmd.Dispose();
            objConnection.Dispose();
            if (res > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert","alert('Data inserted successfully');",true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Something went wrong');",true);
            }

        }

        protected void LoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}