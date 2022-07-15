﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeopleService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PeopleData", Namespace="http://schemas.datacontract.org/2004/07/People")]
    public partial class PeopleData : object
    {
        
        private string FornameField;
        
        private string LastnameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Forname
        {
            get
            {
                return this.FornameField;
            }
            set
            {
                this.FornameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname
        {
            get
            {
                return this.LastnameField;
            }
            set
            {
                this.LastnameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleService.IPeopleService")]
    public interface IPeopleService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/ListPeoples", ReplyAction="http://tempuri.org/IPeopleService/ListPeoplesResponse")]
        System.Threading.Tasks.Task<string[]> ListPeoplesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetPeople", ReplyAction="http://tempuri.org/IPeopleService/GetPeopleResponse")]
        System.Threading.Tasks.Task<PeopleService.PeopleData> GetPeopleAsync(string pId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IPeopleServiceChannel : PeopleService.IPeopleService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<PeopleService.IPeopleService>, PeopleService.IPeopleService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PeopleServiceClient() : 
                base(PeopleServiceClient.GetDefaultBinding(), PeopleServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPeopleService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PeopleServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PeopleServiceClient.GetBindingForEndpoint(endpointConfiguration), PeopleServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PeopleServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PeopleServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PeopleServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PeopleServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string[]> ListPeoplesAsync()
        {
            return base.Channel.ListPeoplesAsync();
        }
        
        public System.Threading.Tasks.Task<PeopleService.PeopleData> GetPeopleAsync(string pId)
        {
            return base.Channel.GetPeopleAsync(pId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPeopleService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPeopleService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:55616/PeopleService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PeopleServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPeopleService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PeopleServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPeopleService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPeopleService,
        }
    }
}