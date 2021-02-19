using InventoryManagementSystem.MyService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    public class InventoryService : IInventoryService
    {
        public string AddProduct(Product prod)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO tblEmployee (EmpID,Name,Email,Phone,Gender)  
                                               Values(@EmpID,@Name,@Email,@Phone,@Gender)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ProdID", prod.ProdID);
                cmd.Parameters.AddWithValue("@Name", prod.Name);
                cmd.Parameters.AddWithValue("@Category", prod.Category);
                cmd.Parameters.AddWithValue("@Quantity", prod.Quantity);
                cmd.Parameters.AddWithValue("@Price", prod.Price);
                cmd.Parameters.AddWithValue("@Supplier", prod.Supplier);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }
        public DataSet GetProducts()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Query = "SELECT * FROM products";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }
        public string DeleteProduct(Product prod)
        {
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            string Query1 = "Select Quantity from products where ProdID=@ProdID";
            string Query = "DELETE FROM products Where ProdID=@ProdID";
            string Query2 = "update products set quantity=quantity=quantity-1 where ProdID=@ProdID";
            cmd = new SqlCommand(Query, con);
            cmd1 = new SqlCommand(Query1, con);
            SqlCommand cmd2 = new SqlCommand(Query2, con);
            cmd1.Parameters.AddWithValue("@ProdID", prod.ProdID);
            cmd.Parameters.AddWithValue("@ProdID", prod.ProdID);
            cmd.Parameters.AddWithValue("@ProdID", prod.ProdID);
            con.Open();
            SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                if ((int)rd[0] > 1)
                {
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }

            }
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }
        public DataSet SearchProduct(Product prod)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Query = "SELECT * FROM products WHERE ProdID=@ProdID";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@ProdID", prod.ProdID);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }
        public string UpdateProduct(Product prod)
        {
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE products SET Quantity=@Quantity,Price=@Price WHERE ProdID=@ProdID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ProdID", prod.ProdID);
            cmd.Parameters.AddWithValue("@Quantity", prod.Quantity);
            cmd.Parameters.AddWithValue("@Price", prod.Price);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
