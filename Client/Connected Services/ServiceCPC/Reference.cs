﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceCPC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCPC.IServiceCPC", CallbackContract=typeof(Client.ServiceCPC.IServiceCPCCallback))]
    public interface IServiceCPC {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/Connect", ReplyAction="http://tempuri.org/IServiceCPC/ConnectResponse")]
        int Connect(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/Connect", ReplyAction="http://tempuri.org/IServiceCPC/ConnectResponse")]
        System.Threading.Tasks.Task<int> ConnectAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/Disconnect", ReplyAction="http://tempuri.org/IServiceCPC/DisconnectResponse")]
        void Disconnect(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/Disconnect", ReplyAction="http://tempuri.org/IServiceCPC/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCPC/SendMessage")]
        void SendMessage(string message, int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCPC/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string message, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/GetData", ReplyAction="http://tempuri.org/IServiceCPC/GetDataResponse")]
        System.Data.DataTable GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/GetData", ReplyAction="http://tempuri.org/IServiceCPC/GetDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/InsertData", ReplyAction="http://tempuri.org/IServiceCPC/InsertDataResponse")]
        string InsertData(string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCPC/InsertData", ReplyAction="http://tempuri.org/IServiceCPC/InsertDataResponse")]
        System.Threading.Tasks.Task<string> InsertDataAsync(string description);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCPCCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCPC/MessageCallBack")]
        void MessageCallBack(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCPCChannel : Client.ServiceCPC.IServiceCPC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCPCClient : System.ServiceModel.DuplexClientBase<Client.ServiceCPC.IServiceCPC>, Client.ServiceCPC.IServiceCPC {
        
        public ServiceCPCClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceCPCClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceCPCClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCPCClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCPCClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Connect(string login) {
            return base.Channel.Connect(login);
        }
        
        public System.Threading.Tasks.Task<int> ConnectAsync(string login) {
            return base.Channel.ConnectAsync(login);
        }
        
        public void Disconnect(int id) {
            base.Channel.Disconnect(id);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(int id) {
            return base.Channel.DisconnectAsync(id);
        }
        
        public void SendMessage(string message, int id) {
            base.Channel.SendMessage(message, id);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string message, int id) {
            return base.Channel.SendMessageAsync(message, id);
        }
        
        public System.Data.DataTable GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public string InsertData(string description) {
            return base.Channel.InsertData(description);
        }
        
        public System.Threading.Tasks.Task<string> InsertDataAsync(string description) {
            return base.Channel.InsertDataAsync(description);
        }
    }
}
