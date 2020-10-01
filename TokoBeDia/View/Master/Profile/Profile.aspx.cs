using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.Profile
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user_id"] == null)
            {
                Response.Redirect("../Login/Login.aspx");
            }
            UserProfile.Text = Session["user_name"].ToString()+"'s Profile";
            rptProfile.DataSource = UserRepository.GetUserProfile(Convert.ToInt32(Session["user_id"].ToString()));
            rptProfile.DataBind();
        }

        protected void rptProfile_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblEmail = (Label)e.Item.FindControl("lblEmail");
            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblGender = (Label)e.Item.FindControl("lblGender");
            MsUser user = (MsUser)e.Item.DataItem;

            lblEmail.Text = user.Email.ToString();
            lblName.Text = user.Name.ToString();
            lblGender.Text = user.Gender.ToString();
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("../UpdateProfile/UpdateProfile.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ChangePassword/ChangePassword.aspx");
        }
    }
}