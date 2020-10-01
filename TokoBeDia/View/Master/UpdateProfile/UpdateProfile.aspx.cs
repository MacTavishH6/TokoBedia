using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.UpdateProfile
{
    public partial class UpdateProfile : System.Web.UI.Page
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
                MsUser user = UserRepository.GetUserProfile(Convert.ToInt32(Session["user_id"].ToString())).ElementAt(0);
                txtEmail.Text = user.Email.ToString();
                txtName.Text = user.Name.ToString();
                ddlGender.SelectedValue = user.Gender.ToString();
            }
            
        }

        protected void HideErrorMessage()
        {
            lblError.Visible = false;

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            string Email = txtEmail.Text.ToString();
            string Name = txtName.Text.ToString();
            string Gender = ddlGender.SelectedValue.ToString();

            if(Email == "" || Name == "" || Gender == "")
            {
                lblError.Visible = true;
            }

            UserRepository.UpdateUserProfile(Convert.ToInt32(Session["user_id"].ToString()), Email, Name, Gender);
            Response.Redirect("../Profile/Profile.aspx");
        }
    }
}