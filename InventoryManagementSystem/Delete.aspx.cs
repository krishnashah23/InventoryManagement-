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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGridData();
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
            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Krishna\Source\repos\InventoryManagementSystem\InventoryManagementSystem\InventoryManagementSystem\App_Data\Products.mdf;Integrated Security=True;MultipleActiveResultSets=true");
            con.Open();
            String Query1 = "Select quantity from prod where id='" + Int32.Parse(id.Text) + "'and name ='" + name.Text + "'";
            string Query = "DELETE FROM prod Where id='" + Int32.Parse(id.Text) + "'" ;
            string Query2 = "update prod set quantity=quantity-1 where id='" + Int32.Parse(id.Text) + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlCommand cmd1 = new SqlCommand(Query1, con);
            SqlCommand cmd2 = new SqlCommand(Query2, con);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    if ((int)rd[0] > 1)
                    {
                        cmd2.ExecuteNonQuery();
                        Response.Redirect("ViewAll.aspx");
                    }
                    else if ((int)rd[0] == 1)
                    {
                        cmd.ExecuteNonQuery();
                        Response.Redirect("ViewAll.aspx");
                    }
                    else
                    {
                        Label1.Text = "No such product exists";
                    }

                }
                
            }
            else
                Label1.Text = "No such product exists";
            con.Close();*/
        }
    }
}