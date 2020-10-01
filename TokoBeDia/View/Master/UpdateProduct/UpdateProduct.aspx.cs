using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.UpdateProduct
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user_role"] == null || Session["user_role"].ToString() != "Admin")
                {
                    Response.Redirect("../Home/index.aspx");
                }
                ddlProductType.DataSource = ProductRepository.GetProductType();
                ddlProductType.DataBind();
                ddlProductType.DataTextField = "Name";
                ddlProductType.DataValueField = "ID";
                ddlProductType.DataBind();
                MsProduct product = ProductRepository.GetOneProduct(Convert.ToInt32(Session["update_id"].ToString())).ElementAt(0);
                txtProductName.Text = product.Name.ToString();
                txtStock.Text = product.Stock.ToString();
                txtPrice.Text = product.Price.ToString();
                ddlProductType.SelectedValue = product.ProductTypeID.ToString();
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string Name = txtProductName.Text.ToString();
            int Stock = Convert.ToInt32(txtStock.Text.ToString());
            int Price = Convert.ToInt32(txtPrice.Text.ToString());
            int Type = Convert.ToInt32(ddlProductType.SelectedValue);
            ProductRepository.UpdateProduct(Convert.ToInt32(Session["update_id"].ToString()), Name, Stock, Type, Price);
            Session.Remove("update_id");
            Response.Redirect("../ViewProduct/ViewProduct.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }
    }
}