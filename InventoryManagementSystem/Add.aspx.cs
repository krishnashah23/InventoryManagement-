using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystem
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if ((id.Text != "") || (name.Text != "") || (category.Text != "") || (quantity.Text != "") || (price.Text != "") || (supplier.Text != ""))
            {
                try
                 {
                     MyService.Product prod = new MyService.Product();
                     prod.ProdID = id.Text;
                     prod.Name = name.Text;
                     prod.Category = category.Text;
                     prod.Quantity = Int32.Parse(quantity.Text);
                     prod.Price = Int32.Parse(price.Text);
                     prod.Supplier = supplier.Text;
                     MyService.InventoryServiceClient client = new MyService.InventoryServiceClient();
                     Label1.Text = "ProductID ID: " + prod.ProdID + ", " + client.AddProduct(prod);
                 }
                 catch (Exception ex)
                 {
                     Label1.Text = ex.ToString();
                 }
               /* SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Krishna\Source\repos\InventoryManagementSystem\InventoryManagementSystem\InventoryManagementSystem\App_Data\Products.mdf; Integrated Security = True; MultipleActiveResultSets = true");
                con.Open();
                String cmd = "Insert into prod(id,name,category,quantity,price,supplier) values ('" + id.Text + "','" + name.Text + "','" + category.Text + "','" + Int32.Parse(quantity.Text) + "','" + Int32.Parse(price.Text) + "','" + supplier.Text + "')";
                SqlCommand command = new SqlCommand(cmd, con);
                int m = command.ExecuteNonQuery();
                if( m != 0)
                {
                     Label1.Text = "Record added";
                }
                else
                {
                    Label1.Text = "Error in adding the record";
                }
                con.Close();*/
            }

            else
            {

                Label1.Text = "All fields are mandatory! ";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
               
        protected void bntReset_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            category.Text = "";
            quantity.Text = "";
            price.Text = "";
            supplier.Text = "";
        }
    }
}