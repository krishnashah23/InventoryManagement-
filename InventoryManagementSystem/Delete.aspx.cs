using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystem
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }
        public void BindGridData()
        {
            DataSet ds = new DataSet();
            MyService.InventoryServiceClient client = new MyService.InventoryServiceClient();
            ds = client.GetProducts();
            grdEmployees.DataSource = ds;
            grdEmployees.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MyService.InventoryServiceClient client = new MyService.InventoryServiceClient();

            MyService.Product prod = new MyService.Product();
            prod.ProdID = txtSearch.Text.Trim();
            string result = client.DeleteProduct(prod);

            if (result == "Record Deleted Successfully!")
            {
                BindGridData();
                lblSearchResult.Text = "Product ID: " + txtSearch.Text.Trim() + "Deleted Successfully!";
            }
            else
            {
                lblSearchResult.Text = "Product ID: " + txtSearch.Text.Trim() + "Not Found!";
            }
        }
    }
}