using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.ViewProduct
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HideAdminAction();
                string user = Session["user_role"] == null ? "Guest" : Session["user_role"].ToString();
                if (user == "Admin")
                {
                    Admin.Visible = true;
                    AdminHeader.Visible = true;
                }
                rptProducts.DataSource = ProductRepository.GetAllProduct();
                rptProducts.DataBind();
            }
            
        }

        protected void HideAdminAction()
        {
            Admin.Visible = false;
        }

        protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblProductID = (Label)e.Item.FindControl("lblProductID");
            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblProductStock = (Label)e.Item.FindControl("lblProductStock");
            Label lblProductType = (Label)e.Item.FindControl("lblProductType");
            Label lblProductQuantity = (Label)e.Item.FindControl("lblProductQuantity");
            var div = e.Item.FindControl("AdminAction");      
            string user = Session["user_role"] == null ? "Guest" : Session["user_role"].ToString();
            MsProduct Product = (MsProduct)e.Item.DataItem;

            if (user == "Admin")
            {
                div.Visible = true;
            }

            lblProductID.Text = Product.ID.ToString();
            lblProductName.Text = Product.Name.ToString();
            lblProductStock.Text = Product.Stock.ToString();
            lblProductQuantity.Text = Product.Price.ToString();
            MsProductType ProductType = ProductRepository.GetProductName(Product.ProductTypeID).ElementAt(0);
            lblProductType.Text = ProductType.Name.ToString();
            if (user == "Admin")
            {
                Button lbUpdate = (Button)e.Item.FindControl("lbUpdate");
                Button lbDelete = (Button)e.Item.FindControl("lbDelete");

                lbDelete.CommandArgument = Product.ID.ToString();
                lbUpdate.CommandArgument = Product.ID.ToString();
            }

        }

        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Button lbUpdate = (Button)e.Item.FindControl("lbUpdate");
            Button lbDelete = (Button)e.Item.FindControl("lbDelete");

            if(e.CommandName == "Update")
            {
                Session["update_id"] = Convert.ToInt32(lbUpdate.CommandArgument);
                Response.Redirect("../UpdateProduct/UpdateProduct.aspx");
            }
            if(e.CommandName == "Delete")
            {
                ProductRepository.DeleteProduct(Convert.ToInt32(lbDelete.CommandArgument));
                Response.Redirect("../ViewProduct/ViewProduct.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("../InsertProduct/InsertProduct.aspx");
        }
    }
}