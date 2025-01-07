using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserToken"] != null)
        {
            Response.Redirect("ViewPatients.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();

        try
        {
            var authService = new AuthService();
            string token = authService.Login(username, password);

           
            Session["UserToken"] = token;

            Response.Redirect("ViewPatients.aspx");
        }
        catch (Exception ex)
        {
            lblErrorMessage.Visible = true;
            lblErrorMessage.Text = "Login failed: " + ex.Message;
        }
    }

}