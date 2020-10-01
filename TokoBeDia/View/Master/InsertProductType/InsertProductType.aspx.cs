using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.InsertProductType
{
    public partial class InsertProductType : System.Web.UI.Page
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
            else if(ProductType.Length < 5)
            {
                lblError.Text = "Product Type must consist 5 or more character";
                lblError.Visible = true;
            }
            else
            {
                ProductRepository.InsertProductType(ProductType, Description);
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