﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAcessLayer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblEmployee", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class tblEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int empnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string enameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int mgrField;
        
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
        public int empno {
            get {
                return this.empnoField;
            }
            set {
                if ((this.empnoField.Equals(value) != true)) {
                    this.empnoField = value;
                    this.RaisePropertyChanged("empno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ename {
            get {
                return this.enameField;
            }
            set {
                if ((object.ReferenceEquals(this.enameField, value) != true)) {
                    this.enameField = value;
                    this.RaisePropertyChanged("ename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int mgr {
            get {
                return this.mgrField;
            }
            set {
                if ((this.mgrField.Equals(value) != true)) {
                    this.mgrField = value;
                    this.RaisePropertyChanged("mgr");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="customer", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustorName {
            get {
                return this.CustorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustorNameField, value) != true)) {
                    this.CustorNameField = value;
                    this.RaisePropertyChanged("CustorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getemployee", ReplyAction="http://tempuri.org/IService1/getemployeeResponse")]
        DataAcessLayer.ServiceReference1.tblEmployee[] getemployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getemployee", ReplyAction="http://tempuri.org/IService1/getemployeeResponse")]
        System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.tblEmployee[]> getemployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getcustomer", ReplyAction="http://tempuri.org/IService1/getcustomerResponse")]
        DataAcessLayer.ServiceReference1.customer[] getcustomer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getcustomer", ReplyAction="http://tempuri.org/IService1/getcustomerResponse")]
        System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.customer[]> getcustomerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        DataAcessLayer.ServiceReference1.tblEmployee GetEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.tblEmployee> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addrecord", ReplyAction="http://tempuri.org/IService1/addrecordResponse")]
        void addrecord(DataAcessLayer.ServiceReference1.tblEmployee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addrecord", ReplyAction="http://tempuri.org/IService1/addrecordResponse")]
        System.Threading.Tasks.Task addrecordAsync(DataAcessLayer.ServiceReference1.tblEmployee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecordById", ReplyAction="http://tempuri.org/IService1/DeleteRecordByIdResponse")]
        void DeleteRecordById(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecordById", ReplyAction="http://tempuri.org/IService1/DeleteRecordByIdResponse")]
        System.Threading.Tasks.Task DeleteRecordByIdAsync(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditRowById", ReplyAction="http://tempuri.org/IService1/EditRowByIdResponse")]
        void EditRowById(DataAcessLayer.ServiceReference1.tblEmployee t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditRowById", ReplyAction="http://tempuri.org/IService1/EditRowByIdResponse")]
        System.Threading.Tasks.Task EditRowByIdAsync(DataAcessLayer.ServiceReference1.tblEmployee t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        DataAcessLayer.ServiceReference1.tblEmployee[] Login(string uname, int pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.tblEmployee[]> LoginAsync(string uname, int pswd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DataAcessLayer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DataAcessLayer.ServiceReference1.IService1>, DataAcessLayer.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DataAcessLayer.ServiceReference1.tblEmployee[] getemployee() {
            return base.Channel.getemployee();
        }
        
        public System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.tblEmployee[]> getemployeeAsync() {
            return base.Channel.getemployeeAsync();
        }
        
        public DataAcessLayer.ServiceReference1.customer[] getcustomer() {
            return base.Channel.getcustomer();
        }
        
        public System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.customer[]> getcustomerAsync() {
            return base.Channel.getcustomerAsync();
        }
        
        public DataAcessLayer.ServiceReference1.tblEmployee GetEmployeeById(int id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.tblEmployee> GetEmployeeByIdAsync(int id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public void addrecord(DataAcessLayer.ServiceReference1.tblEmployee e) {
            base.Channel.addrecord(e);
        }
        
        public System.Threading.Tasks.Task addrecordAsync(DataAcessLayer.ServiceReference1.tblEmployee e) {
            return base.Channel.addrecordAsync(e);
        }
        
        public void DeleteRecordById(int i) {
            base.Channel.DeleteRecordById(i);
        }
        
        public System.Threading.Tasks.Task DeleteRecordByIdAsync(int i) {
            return base.Channel.DeleteRecordByIdAsync(i);
        }
        
        public void EditRowById(DataAcessLayer.ServiceReference1.tblEmployee t) {
            base.Channel.EditRowById(t);
        }
        
        public System.Threading.Tasks.Task EditRowByIdAsync(DataAcessLayer.ServiceReference1.tblEmployee t) {
            return base.Channel.EditRowByIdAsync(t);
        }
        
        public DataAcessLayer.ServiceReference1.tblEmployee[] Login(string uname, int pswd) {
            return base.Channel.Login(uname, pswd);
        }
        
        public System.Threading.Tasks.Task<DataAcessLayer.ServiceReference1.tblEmployee[]> LoginAsync(string uname, int pswd) {
            return base.Channel.LoginAsync(uname, pswd);
        }
    }
}