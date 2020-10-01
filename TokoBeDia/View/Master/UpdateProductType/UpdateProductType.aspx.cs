using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.UpdateProductType
{
    public partial class UpdateProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HideErrorMessage();
                if (Session["user_role"] == null || Session["user_role"].ToString() != "Admin")
                {
                    Response.Redirect("../Home/index.aspx");
                }
                MsProductType ProductType = ProductRepository.GetOneProductType(Convert.ToInt32(Session["update_id"].ToString())).ElementAt(0);
                txtProductType.Text = ProductType.Name.ToString();
                txtDescription.Text = ProductType.Description.ToString();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            string ProductType = txtProductType.Text.ToString();
            string Description = txtDescription.Text.ToString();

            if(ProductType == "" || Description == "")
            {
                lblError.Visible = true;
            }
            else
            {
                ProductRepository.UpdateProductType(Convert.ToInt32(Session["update_id"].ToString()), ProductType, Description);
                Session.Remove("update_id");
                Response.Redirect("../ViewProductType/ViewProductType.aspx");
            }
        }
        protected void HideErrorMessage()
        {
            lblError.Visible = false;
            lblError.Text = "All field must not be empty";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }
    }
}