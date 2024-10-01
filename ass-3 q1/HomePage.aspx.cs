using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace ass_3_q1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void viewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void uploadProfilePhoto_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    HttpPostedFile uploadedeFile = FileUpload1.PostedFile;
                    byte[] fileBytes;
                    BinaryReader reader = new BinaryReader(uploadedeFile.InputStream);
                    fileBytes = reader.ReadBytes(uploadedeFile.ContentLength);
                    string base64String = Convert.ToBase64String(fileBytes);
                    string userName = "";
                    //Response.Write("<script>const lsGet = JSON.parse(localStorage.getItem('userObj')); '"+userName+"'= lsGet.username;</script>;");
                    var getData = (dynamic)Session["userObj"];
                    Response.Write("<script>console.log('" + getData + "');</script>;");

                    Response.Write("<script>console.log('"+ base64String + "');</script>;");

                }
                catch (Exception ex)
                {
                    Response.Write("something went wrong with file");
                }
            }
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            // Use JavaScript to show a confirmation dialog
            Response.Write("<script>" +
                           "if (confirm('Do you really want to logout?')) {" +
                           "   localStorage.removeItem('isLoggedIn');" +
                           "   window.location.href = 'LoginPage.aspx';" +
                           "} else {" +
                           "   window.location.href = 'HomePage.aspx';" +  // Stay on HomePage if canceled
                           "}" +
                           "</script>");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
        }
    }
}