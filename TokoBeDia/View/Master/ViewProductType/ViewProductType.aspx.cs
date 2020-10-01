using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;
using TokoBeDia.Repository;

namespace TokoBeDia.View.Master.ViewProductType
{
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user_role"] == null || Session["user_role"].ToString() != "Admin")
                {
                    Response.Redirect("../Home/index.aspx");
                }

                rptProducts.DataSource = ProductRepository.GetProductType();
                rptProducts.DataBind();
            }
        }

        protected void btnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../InsertProductType/InsertProductType");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home/index.aspx");
        }

        protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblProductTypeID = (Label)e.Item.FindControl("lblProductTypeID");
            Label lblProductType = (Label)e.Item.FindControl("lblProductType");
            TextBox txtDesc = (TextBox)e.Item.FindControl("txtDesc");
            MsProductType ProductType = (MsProductType)e.Item.DataItem;

            lblProductTypeID.Text = ProductType.ID.ToString();
            lblProductType.Text = ProductType.Name.ToString();
            txtDesc.Text = ProductType.Description.ToString();

            Button lbUpdate = (Button)e.Item.FindControl("lbUpdate");
            Button lbDelete = (Button)e.Item.FindControl("lbDelete");

            lbDelete.CommandArgument = ProductType.ID.ToString();
            lbUpdate.CommandArgument = ProductType.ID.ToString();
        }

        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Button lbUpdate = (Button)e.Item.FindControl("lbUpdate");
            Button lbDelete = (Button)e.Item.FindControl("lbDelete");

            if (e.CommandName == "Update")
            {
                Session["update_id"] = Convert.ToInt32(lbUpdate.CommandArgument);
                Response.Redirect("../UpdateProductType/UpdateProductType.aspx");
            }
            if (e.CommandName == "Delete")
            {
                ProductRepository.DeleteProductType(Convert.ToInt32(lbDelete.CommandArgument));
                Response.Redirect("../ViewProductType/ViewProductType.aspx");
            }
        }

        protected void btnInsertProductType_Click1(object sender, EventArgs e)
        {
            Response.Redirect("../InsertProductType/InsertProductType.aspx");
        }
    }
}