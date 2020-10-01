using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.ChangePassword
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HideErrorMessage();
                if (Session["user_id"] == null)
                {
                    Response.Redirect("../Home/index.aspx");
                }
            }
        }

        protected void lblHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            string OldPassword = txtOldPassword.Text.ToString();
            string NewPassword = txtNewPassword.Text.ToString();
            string ConfirmPassword = txtConfirmPassword.Text.ToString();
            int count = UserRepository.CheckPassword(Convert.ToInt32(Session["user_id"].ToString()), OldPassword.ToString()).Count;

            if (OldPassword == "" || NewPassword == "" || ConfirmPassword == "")
            {
                lblError.Visible = true;
            }
            else if(!String.Equals(NewPassword, ConfirmPassword))
            {
                lblConfirmError.Visible = true;
            }
            else if(count < 1)
            {
                lblOldPasswordError.Visible = true;
            }
            else
            {
                UserRepository.ResetPassword(Convert.ToInt32(Session["user_id"].ToString()), ConfirmPassword);
                Response.Redirect("../Profile/Profile.aspx");
            }
        }
        protected void HideErrorMessage()
        {
            lblError.Visible = false;
            lblConfirmError.Visible = false;
            lblOldPasswordError.Visible = false;
        }
    }
}