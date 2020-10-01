using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.InsertProduct
{
    public partial class InsertProduct : System.Web.UI.Page
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
                ddlProductType.DataSource = ProductRepository.GetProductType();
                ddlProductType.DataBind();
                ddlProductType.DataTextField = "Name";
                ddlProductType.DataValueField = "ID";
                ddlProductType.DataBind();
            }
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            string Name = txtProductName.Text;
            int ProductType = Convert.ToInt32(ddlProductType.SelectedValue.ToString());
            int Stock = Convert.ToInt32(txtStock.Text) == 0 ? 0 : Convert.ToInt32(txtStock.Text);
            int Price = Convert.ToInt32(txtPrice.Text) == 0 ? 0 : Convert.ToInt32(txtPrice.Text);

            if(Name == "" || Stock == 0 || Price == 0)
            {
                lblError.Visible = true;
            }
            if(Stock < 1)
            {
                lblError.Text = "Stock must be 1 or more";
                lblError.Visible = true;
            }
            if(Price < 1000)
            {
                lblError.Text = "Price must be more than 1000";
                lblError.Visible = true;
            }
            else
            {
                ProductRepository.InsertProduct(Name, Stock, Price, ProductType);
                Response.Redirect("../ViewProduct/ViewProduct.aspx");
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