using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.ViewUser
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user_role"] == null || Session["user_role"].ToString() != "Admin")
                {
                    Response.Redirect("../Home/index.aspx");
                }
                rptUser.DataSource = UserRepository.GetAllUserExcept(Session["user_email"].ToString(), Session["user_name"].ToString());
                rptUser.DataBind();
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }

        protected void rptUser_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblUserID = (Label)e.Item.FindControl("lblUserID");
            Label lblName = (Label)e.Item.FindControl("lblName");
            Label lblEmail = (Label)e.Item.FindControl("lblEmail");
            DropDownList ddlRole = (DropDownList)e.Item.FindControl("ddlRole");
            DropDownList ddlStatus = (DropDownList)e.Item.FindControl("ddlStatus");
            MsUser user = (MsUser)e.Item.DataItem;

            lblUserID.Text = user.ID.ToString();
            lblName.Text = user.Name.ToString();
            lblEmail.Text = user.Email.ToString();
            ddlRole.DataSource = UserRepository.GetAllRole();
            ddlRole.DataBind();
            ddlRole.DataTextField = "Name";
            ddlRole.DataValueField = "ID";
            ddlRole.DataBind();
            ddlRole.SelectedValue = user.RoleID.ToString();
            ddlStatus.SelectedValue = user.Status;
        }

        protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlRole = (DropDownList)sender;
            RepeaterItem Item = (RepeaterItem)ddlRole.NamingContainer;
            Label lblUserID = (Label)Item.FindControl("lblUserID");
            DropDownList ddlRoleValue = (DropDownList)Item.FindControl("ddlRole");
            DropDownList ddlStatus = (DropDownList)Item.FindControl("ddlStatus");

            int UserID = Convert.ToInt32(lblUserID.Text.ToString());
            int RoleID = Convert.ToInt32(ddlRoleValue.SelectedValue);
            string Status = ddlStatus.SelectedValue.ToString();

            UserRepository.UpdateUser(UserID, RoleID, Status);
        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlStatus = (DropDownList)sender;
            RepeaterItem Item = (RepeaterItem)ddlStatus.NamingContainer;
            Label lblUserID = (Label)Item.FindControl("lblUserID");
            DropDownList ddlRoleValue = (DropDownList)Item.FindControl("ddlRole");
            DropDownList ddlStatusValue = (DropDownList)Item.FindControl("ddlStatus");

            int UserID = Convert.ToInt32(lblUserID.Text.ToString());
            int RoleID = Convert.ToInt32(ddlRoleValue.SelectedValue);
            string Status = ddlStatusValue.SelectedValue.ToString();

            UserRepository.UpdateUser(UserID, RoleID, Status);
        }

    }
}