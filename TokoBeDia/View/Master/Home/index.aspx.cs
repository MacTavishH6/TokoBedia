using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.Home
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HideAllDiv();
            
            string user = Session["user_role"] == null ? "Guest" : Session["user_role"].ToString();
            switch (user)
            {
                case "Guest":
                    lblWelcome.Text = "Welcome " + user;
                    divGuest.Visible = true;
                    rptProducts.DataSource = ProductRepository.GetFiveProduct();
                    rptProducts.DataBind();
                    Session.RemoveAll();
                    break;
                case "Member":
                    lblWelcome.Text = "Welcome " + Session["user_name"].ToString();
                    divLoggedOn.Visible = true;
                    rptProducts.DataSource = ProductRepository.GetFiveProduct();
                    rptProducts.DataBind();
                    break;
                case "Admin":
                    lblWelcome.Text = "Welcome " + Session["user_name"].ToString();
                    table.Visible = false;
                    divLoggedOn.Visible = true;
                    divAdmin.Visible = true;
                    break;
            }
            
        }

        protected void HideAllDiv()
        {
            divGuest.Visible = false;
            divLoggedOn.Visible = false;
            divAdmin.Visible = false;
        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ViewProduct/ViewProduct.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }

        protected void btnViewProductLoggedOn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ViewProduct/ViewProduct.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Profile/Profile.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../Login/Login.aspx");
        }

        protected void btnViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ViewUser/ViewUser.aspx");
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("../InsertProduct/InsertProduct.aspx");
        }

        protected void btnUpdateProduce_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ViewProduct/ViewProduct.aspx");
        }

        protected void btnViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ViewProductType/ViewProductType.aspx");
        }

        protected void btnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../InsertProductType/InsertProductType.aspx");
        }

        protected void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ViewProductType/ViewProductType.aspx");
        }

        protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblProductID = (Label)e.Item.FindControl("lblProductID");
            Label lblProductName = (Label)e.Item.FindControl("lblProductName");
            Label lblProductStock = (Label)e.Item.FindControl("lblProductStock");
            Label lblProductType = (Label)e.Item.FindControl("lblProductType");
            Label lblProductQuantity = (Label)e.Item.FindControl("lblProductQuantity");
            string user = Session["user_role"] == null ? "Guest" : Session["user_role"].ToString();
            MsProduct Product = (MsProduct)e.Item.DataItem;

            lblProductID.Text = Product.ID.ToString();
            lblProductName.Text = Product.Name.ToString();
            lblProductStock.Text = Product.Stock.ToString();
            lblProductQuantity.Text = Product.Price.ToString();
            MsProductType ProductType = ProductRepository.GetProductName(Product.ProductTypeID).ElementAt(0);
            lblProductType.Text = ProductType.Name.ToString();
        }
    }
}