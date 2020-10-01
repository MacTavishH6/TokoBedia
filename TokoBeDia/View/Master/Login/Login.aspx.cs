using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Factory;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HideErrorMessage();
            string role = Session["user_role"] == null ? "Guest" : Session["user_role"].ToString();

            if (role != "Guest")
            {
                Response.Redirect("../Home/index.aspx");
            }

            if (Response.Cookies["user_email"].Value != null)
            {
                txtEmail.Text = Response.Cookies["user_email"].Value;
                cbxRememberme.Checked = true;
            }            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;

            if(Email == "" || Password == "")
            {
                lblError.Visible = true;
            }else
            {
                int exists = UserRepository.CheckUser(Email).Count;
                if (exists < 1)
                {
                    lblUserError.Visible = true;
                }
                else
                {
                    int success = UserRepository.GetUser(Email, Password).Count;
                    if(success < 1)
                    {
                        lblPasswordError.Visible = true;
                    }
                    else
                    {
                        if(cbxRememberme.Checked == true)
                        {
                            Response.Cookies["user_email"].Value = Email;
                        }
                        else
                        {
                            Response.Cookies["user_email"].Value = null;
                        }
                        MsUser user = UserRepository.GetUser(Email, Password).ElementAt(0);
                        switch (user.RoleID)
                        {
                            case 1:
                                Session["user_role"] = "Admin";
                                break;
                            case 2:
                                Session["user_role"] = "Member";
                                break;
                        }
                        Session["user_id"] = user.ID.ToString();
                        Session["user_email"] = user.Email.ToString();
                        Session["user_name"] = user.Name.ToString();
                        Response.Redirect("../Home/index.aspx");
                    }
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Register/Register.aspx");
        }

        protected void HideErrorMessage()
        {
            lblError.Visible = false;
            lblUserError.Visible = false;
            lblPasswordError.Visible = false;

        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }
    }
}