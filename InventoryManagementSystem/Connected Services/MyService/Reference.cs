﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagementSystem.MyService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/InventoryService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProdIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SupplierField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProdID {
            get {
                return this.ProdIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdIDField, value) != true)) {
                    this.ProdIDField = value;
                    this.RaisePropertyChanged("ProdID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Supplier {
            get {
                return this.SupplierField;
            }
            set {
                if ((object.ReferenceEquals(this.SupplierField, value) != true)) {
                    this.SupplierField = value;
                    this.RaisePropertyChanged("Supplier");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IInventoryService")]
    public interface IInventoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetData", ReplyAction="http://tempuri.org/IInventoryService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetData", ReplyAction="http://tempuri.org/IInventoryService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddProduct", ReplyAction="http://tempuri.org/IInventoryService/AddProductResponse")]
        string AddProduct(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddProduct", ReplyAction="http://tempuri.org/IInventoryService/AddProductResponse")]
        System.Threading.Tasks.Task<string> AddProductAsync(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetProducts", ReplyAction="http://tempuri.org/IInventoryService/GetProductsResponse")]
        System.Data.DataSet GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetProducts", ReplyAction="http://tempuri.org/IInventoryService/GetProductsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/DeleteProduct", ReplyAction="http://tempuri.org/IInventoryService/DeleteProductResponse")]
        string DeleteProduct(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/DeleteProduct", ReplyAction="http://tempuri.org/IInventoryService/DeleteProductResponse")]
        System.Threading.Tasks.Task<string> DeleteProductAsync(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/SearchProduct", ReplyAction="http://tempuri.org/IInventoryService/SearchProductResponse")]
        System.Data.DataSet SearchProduct(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/SearchProduct", ReplyAction="http://tempuri.org/IInventoryService/SearchProductResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchProductAsync(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/UpdateProduct", ReplyAction="http://tempuri.org/IInventoryService/UpdateProductResponse")]
        string UpdateProduct(InventoryManagementSystem.MyService.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/UpdateProduct", ReplyAction="http://tempuri.org/IInventoryService/UpdateProductResponse")]
        System.Threading.Tasks.Task<string> UpdateProductAsync(InventoryManagementSystem.MyService.Product prod);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryServiceChannel : InventoryManagementSystem.MyService.IInventoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryServiceClient : System.ServiceModel.ClientBase<InventoryManagementSystem.MyService.IInventoryService>, InventoryManagementSystem.MyService.IInventoryService {
        
        public InventoryServiceClient() {
        }
        
        public InventoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string AddProduct(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.AddProduct(prod);
        }
        
        public System.Threading.Tasks.Task<string> AddProductAsync(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.AddProductAsync(prod);
        }
        
        public System.Data.DataSet GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public string DeleteProduct(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.DeleteProduct(prod);
        }
        
        public System.Threading.Tasks.Task<string> DeleteProductAsync(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.DeleteProductAsync(prod);
        }
        
        public System.Data.DataSet SearchProduct(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.SearchProduct(prod);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchProductAsync(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.SearchProductAsync(prod);
        }
        
        public string UpdateProduct(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.UpdateProduct(prod);
        }
        
        public System.Threading.Tasks.Task<string> UpdateProductAsync(InventoryManagementSystem.MyService.Product prod) {
            return base.Channel.UpdateProductAsync(prod);
        }
    }
}
