using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        }

        protected void uploadProfilePhoto_Click(object sender, EventArgs e)
        {

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Write("<script>localStorage.removeItem('isLoggedIn'); window.location.href = 'LoginPage.aspx'</script>");
        }
    }
}