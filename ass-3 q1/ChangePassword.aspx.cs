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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changePassword_Click(object sender, EventArgs e)
        {
            string txtOldPass = oldPassword.Text;
            string txtNewPass = newPassword.Text;
            string txtUserName = userName.Text;
            string connectionStr = "Server=DESKTOP-RC1CAM9;Database=loginRegister;Trusted_Connection=True;";
            SqlConnection objConnection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConnection;
            cmd.CommandText = "update tblRegister set password = '" + txtNewPass+"' where password = '"+txtOldPass+"' and userName = '"+ txtUserName + "';";

            objConnection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Write("<script>alert('user passord is updated')</script>");
            }
            else
            {
                Response.Write("<script>alert('user old passord is incorrect')</script>");
            }
            objConnection.Close();
            cmd.Dispose();
            objConnection.Dispose();
        }
    }
}