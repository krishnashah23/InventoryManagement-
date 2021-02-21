using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystem
{
    public partial class Update : System.Web.UI.Page
    {
        MyService.Product prod = new MyService.Product();
        MyService.InventoryServiceClient client = new MyService.InventoryServiceClient();

        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetPanel(true, false);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                prod.ProdID = txtSearch.Text.Trim();
                ds = new DataSet();
                ds = client.SearchProduct(prod);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    id.Text = ds.Tables[0].Rows[0]["ProdID"].ToString();
                    quantity.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                    price.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                    SetPanel(false, true);

                }
                else
                {
                    lblSearchResult.Text = "No such product exists";
                    lblSearchResult.ForeColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                lblSearchResult.Text = "Please Enter Product ID !";
            }
        }
        private void SetPanel(bool pSearch, bool pUpdate)
        {
            panSearch.Visible = pSearch;
            panUpdate.Visible = pUpdate;
        }
        protected void bntReset_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
            lblMsg.Text = "";
        }
        protected void bntUpdated_Click(object sender, EventArgs e)
        {
            prod.ProdID = id.Text.Trim();
            prod.Quantity = Int32.Parse(quantity.Text);
            prod.Price = Int32.Parse(price.Text);

            string result = client.UpdateProduct(prod);
            lblSearchResult.Text = result;
            SetPanel(true, false);
            price.Text = "";
            quantity.Text = "";
            id.Text = "";

        }
        }
    }
}