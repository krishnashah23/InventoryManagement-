using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    [ServiceContract]
    public interface IInventoryService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddProduct(Product prod);

        [OperationContract]
        DataSet GetProducts();

        [OperationContract]
        string DeleteProduct(Product prod);

        [OperationContract]
        DataSet SearchProduct(Product prod);

        [OperationContract]
        string UpdateProduct(Product prod);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Product
    {
        string _prodID = "";
        string _name = "";
        string _category = "";
        int _quantity = 0;
        int _price = 0;
        string _supplier = "";

        [DataMember]
        public string ProdID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [DataMember]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        [DataMember]
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        [DataMember]
        public string Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
    }
}
