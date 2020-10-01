using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.Register
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HideErrorMessage();
            string role = Session["user_role"] == null ? "Guest" : Session["user_role"].ToString();

            if (role != "Guest")
            {
                Response.Redirect("../Home/index.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            string Email = txtEmail.Text;
            string Name = txtName.Text;
            string Password = txtPassword.Text;
            string ConfirmPassword = txtConfirmPassword.Text;
            string Gender = ddlGender.SelectedValue;

            if(Email == "" || Name == "" || Password == "" || ConfirmPassword == "" || Gender == "")
            {
                lblError.Visible = true;
            }

            else if(!String.Equals(Password,ConfirmPassword))
            {
                lblPasswordError.Visible = true;
            }
            else
            {
                UserRepository.InsertUser(Name, Email, Password, Gender);
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "<script>Register Success!</script>", true);
                Response.Redirect("../Login/Login.aspx");
            }
        }
        protected void HideErrorMessage()
        {
            lblError.Visible = false;
            lblPasswordError.Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }
    }
}