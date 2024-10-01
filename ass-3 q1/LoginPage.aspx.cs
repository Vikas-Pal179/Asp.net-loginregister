using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace ass_3_q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerpage_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void login_Click(object sender, EventArgs e)
        {
            string txtUserName = username.Text;
            string txtPassword = password.Text;

            string connectionStr = "Server=DESKTOP-RC1CAM9;Database=loginRegister;Trusted_Connection=True;";
            SqlConnection objConnection = new SqlConnection(connectionStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConnection;
            cmd.CommandText = "select * from tblRegister where userName='" + txtUserName+"' and password= '"+txtPassword+"'";

            objConnection.Open();
            try
            {
                int res = (int)cmd.ExecuteScalar();
                //SqlDataReader reader = cmd.ExecuteReader();
            if (res>0)
                {
                    var data = new {
                        username = txtUserName,
                        password = txtPassword
                    };
                    string jsonData = JsonConvert.SerializeObject(data);
                    Response.Write("<script>localStorage.setItem('userObj', '"+ jsonData + "');</script>");
                    HttpContext.Current.Session["userObjs"] = data;
                    Response.Write("<script>localStorage.setItem('isLoggedIn', 'true'); window.location.href = 'HomePage.aspx';</script>");
                }
            }
            catch (Exception ex) { 
            
                Response.Write("<script>alert('This user not exists')</script>");
            }

            objConnection.Close();
            cmd.Dispose();
            objConnection.Dispose();


        }
    }
}