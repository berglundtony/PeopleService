﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeopleClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IPeopleService")]
    public interface IPeopleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ListPeoples", ReplyAction="http://tempuri.org/IPeopleService/ListPeoplesResponse")]
        int[] ListPeoples();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ListPeoples", ReplyAction="http://tempuri.org/IPeopleService/ListPeoplesResponse")]
        System.Threading.Tasks.Task<int[]> ListPeoplesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPerson", ReplyAction="http://tempuri.org/IPeopleService/GetPersonResponse")]
        PeopleLibrary.Person GetPerson(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPerson", ReplyAction="http://tempuri.org/IPeopleService/GetPersonResponse")]
        System.Threading.Tasks.Task<PeopleLibrary.Person> GetPersonAsync(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetFamily", ReplyAction="http://tempuri.org/IPeopleService/GetFamilyResponse")]
        PeopleLibrary.Family GetFamily(System.Nullable<int> pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetFamily", ReplyAction="http://tempuri.org/IPeopleService/GetFamilyResponse")]
        System.Threading.Tasks.Task<PeopleLibrary.Family> GetFamilyAsync(System.Nullable<int> pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetTelephone", ReplyAction="http://tempuri.org/IPeopleService/GetTelephoneResponse")]
        PeopleLibrary.Telephone GetTelephone(int fId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetTelephone", ReplyAction="http://tempuri.org/IPeopleService/GetTelephoneResponse")]
        System.Threading.Tasks.Task<PeopleLibrary.Telephone> GetTelephoneAsync(int fId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetAddress", ReplyAction="http://tempuri.org/IPeopleService/GetAddressResponse")]
        PeopleLibrary.Address GetAddress(int pfId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetAddress", ReplyAction="http://tempuri.org/IPeopleService/GetAddressResponse")]
        System.Threading.Tasks.Task<PeopleLibrary.Address> GetAddressAsync(int pfId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : PeopleClient.ServiceReference.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<PeopleClient.ServiceReference.IPeopleService>, PeopleClient.ServiceReference.IPeopleService {
        
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
        
        public PeopleLibrary.Person GetPerson(int pId) {
            return base.Channel.GetPerson(pId);
        }
        
        public System.Threading.Tasks.Task<PeopleLibrary.Person> GetPersonAsync(int pId) {
            return base.Channel.GetPersonAsync(pId);
        }
        
        public PeopleLibrary.Family GetFamily(System.Nullable<int> pId) {
            return base.Channel.GetFamily(pId);
        }
        
        public System.Threading.Tasks.Task<PeopleLibrary.Family> GetFamilyAsync(System.Nullable<int> pId) {
            return base.Channel.GetFamilyAsync(pId);
        }
        
        public PeopleLibrary.Telephone GetTelephone(int fId) {
            return base.Channel.GetTelephone(fId);
        }
        
        public System.Threading.Tasks.Task<PeopleLibrary.Telephone> GetTelephoneAsync(int fId) {
            return base.Channel.GetTelephoneAsync(fId);
        }
        
        public PeopleLibrary.Address GetAddress(int pfId) {
            return base.Channel.GetAddress(pfId);
        }
        
        public System.Threading.Tasks.Task<PeopleLibrary.Address> GetAddressAsync(int pfId) {
            return base.Channel.GetAddressAsync(pfId);
        }
    }
}