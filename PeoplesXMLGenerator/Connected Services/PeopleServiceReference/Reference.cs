﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeoplesXMLGenerator.PeopleServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/PeopleLibrary")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FornameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PFIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PIdField;
        
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
        public string Forname {
            get {
                return this.FornameField;
            }
            set {
                if ((object.ReferenceEquals(this.FornameField, value) != true)) {
                    this.FornameField = value;
                    this.RaisePropertyChanged("Forname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PFId {
            get {
                return this.PFIdField;
            }
            set {
                if ((this.PFIdField.Equals(value) != true)) {
                    this.PFIdField = value;
                    this.RaisePropertyChanged("PFId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PId {
            get {
                return this.PIdField;
            }
            set {
                if ((this.PIdField.Equals(value) != true)) {
                    this.PIdField = value;
                    this.RaisePropertyChanged("PId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Family", Namespace="http://schemas.datacontract.org/2004/07/PeopleLibrary")]
    [System.SerializableAttribute()]
    public partial class Family : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> BornField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PFIdField;
        
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
        public System.Nullable<int> Born {
            get {
                return this.BornField;
            }
            set {
                if ((this.BornField.Equals(value) != true)) {
                    this.BornField = value;
                    this.RaisePropertyChanged("Born");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FId {
            get {
                return this.FIdField;
            }
            set {
                if ((this.FIdField.Equals(value) != true)) {
                    this.FIdField = value;
                    this.RaisePropertyChanged("FId");
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
        public int PFId {
            get {
                return this.PFIdField;
            }
            set {
                if ((this.PFIdField.Equals(value) != true)) {
                    this.PFIdField = value;
                    this.RaisePropertyChanged("PFId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Telephone", Namespace="http://schemas.datacontract.org/2004/07/PeopleLibrary")]
    [System.SerializableAttribute()]
    public partial class Telephone : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LandlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TIdField;
        
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
        public System.Nullable<int> FId {
            get {
                return this.FIdField;
            }
            set {
                if ((this.FIdField.Equals(value) != true)) {
                    this.FIdField = value;
                    this.RaisePropertyChanged("FId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Landline {
            get {
                return this.LandlineField;
            }
            set {
                if ((object.ReferenceEquals(this.LandlineField, value) != true)) {
                    this.LandlineField = value;
                    this.RaisePropertyChanged("Landline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PId {
            get {
                return this.PIdField;
            }
            set {
                if ((this.PIdField.Equals(value) != true)) {
                    this.PIdField = value;
                    this.RaisePropertyChanged("PId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TId {
            get {
                return this.TIdField;
            }
            set {
                if ((this.TIdField.Equals(value) != true)) {
                    this.TIdField = value;
                    this.RaisePropertyChanged("TId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/PeopleLibrary")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PFIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ZipField;
        
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
        public int AId {
            get {
                return this.AIdField;
            }
            set {
                if ((this.AIdField.Equals(value) != true)) {
                    this.AIdField = value;
                    this.RaisePropertyChanged("AId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PFId {
            get {
                return this.PFIdField;
            }
            set {
                if ((this.PFIdField.Equals(value) != true)) {
                    this.PFIdField = value;
                    this.RaisePropertyChanged("PFId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PId {
            get {
                return this.PIdField;
            }
            set {
                if ((this.PIdField.Equals(value) != true)) {
                    this.PIdField = value;
                    this.RaisePropertyChanged("PId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((this.ZipField.Equals(value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleServiceReference.IPeopleService")]
    public interface IPeopleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ListPeoples", ReplyAction="http://tempuri.org/IPeopleService/ListPeoplesResponse")]
        int[] ListPeoples();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ListPeoples", ReplyAction="http://tempuri.org/IPeopleService/ListPeoplesResponse")]
        System.Threading.Tasks.Task<int[]> ListPeoplesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPerson", ReplyAction="http://tempuri.org/IPeopleService/GetPersonResponse")]
        PeoplesXMLGenerator.PeopleServiceReference.Person GetPerson(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPerson", ReplyAction="http://tempuri.org/IPeopleService/GetPersonResponse")]
        System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Person> GetPersonAsync(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetFamily", ReplyAction="http://tempuri.org/IPeopleService/GetFamilyResponse")]
        PeoplesXMLGenerator.PeopleServiceReference.Family[] GetFamily(System.Nullable<int> pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetFamily", ReplyAction="http://tempuri.org/IPeopleService/GetFamilyResponse")]
        System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Family[]> GetFamilyAsync(System.Nullable<int> pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetTelephone", ReplyAction="http://tempuri.org/IPeopleService/GetTelephoneResponse")]
        PeoplesXMLGenerator.PeopleServiceReference.Telephone GetTelephone(System.Nullable<int> pFId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetTelephone", ReplyAction="http://tempuri.org/IPeopleService/GetTelephoneResponse")]
        System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Telephone> GetTelephoneAsync(System.Nullable<int> pFId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetAddress", ReplyAction="http://tempuri.org/IPeopleService/GetAddressResponse")]
        PeoplesXMLGenerator.PeopleServiceReference.Address GetAddress(System.Nullable<int> pfId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetAddress", ReplyAction="http://tempuri.org/IPeopleService/GetAddressResponse")]
        System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Address> GetAddressAsync(System.Nullable<int> pfId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPeopleStringList", ReplyAction="http://tempuri.org/IPeopleService/GetPeopleStringListResponse")]
        string[] GetPeopleStringList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPeopleStringList", ReplyAction="http://tempuri.org/IPeopleService/GetPeopleStringListResponse")]
        System.Threading.Tasks.Task<string[]> GetPeopleStringListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : PeoplesXMLGenerator.PeopleServiceReference.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<PeoplesXMLGenerator.PeopleServiceReference.IPeopleService>, PeoplesXMLGenerator.PeopleServiceReference.IPeopleService {
        
        public PeopleServiceClient() {
        }
        
        public PeopleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] ListPeoples() {
            return base.Channel.ListPeoples();
        }
        
        public System.Threading.Tasks.Task<int[]> ListPeoplesAsync() {
            return base.Channel.ListPeoplesAsync();
        }
        
        public PeoplesXMLGenerator.PeopleServiceReference.Person GetPerson(int pId) {
            return base.Channel.GetPerson(pId);
        }
        
        public System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Person> GetPersonAsync(int pId) {
            return base.Channel.GetPersonAsync(pId);
        }
        
        public PeoplesXMLGenerator.PeopleServiceReference.Family[] GetFamily(System.Nullable<int> pId) {
            return base.Channel.GetFamily(pId);
        }
        
        public System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Family[]> GetFamilyAsync(System.Nullable<int> pId) {
            return base.Channel.GetFamilyAsync(pId);
        }
        
        public PeoplesXMLGenerator.PeopleServiceReference.Telephone GetTelephone(System.Nullable<int> pFId) {
            return base.Channel.GetTelephone(pFId);
        }
        
        public System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Telephone> GetTelephoneAsync(System.Nullable<int> pFId) {
            return base.Channel.GetTelephoneAsync(pFId);
        }
        
        public PeoplesXMLGenerator.PeopleServiceReference.Address GetAddress(System.Nullable<int> pfId) {
            return base.Channel.GetAddress(pfId);
        }
        
        public System.Threading.Tasks.Task<PeoplesXMLGenerator.PeopleServiceReference.Address> GetAddressAsync(System.Nullable<int> pfId) {
            return base.Channel.GetAddressAsync(pfId);
        }
        
        public string[] GetPeopleStringList() {
            return base.Channel.GetPeopleStringList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetPeopleStringListAsync() {
            return base.Channel.GetPeopleStringListAsync();
        }
    }
}
