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
    public partial class ViewAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                 MyService.InventoryServiceClient client = new MyService.InventoryServiceClient();
                 ds = client.GetProducts();
                 grdEmployees.DataSource = ds;
                 grdEmployees.DataBind();
            }
        }
       
    }
}