﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerarNumero", ReplyAction="http://tempuri.org/IService1/GenerarNumeroResponse")]
        int GenerarNumero(int p_iNumeroTecho, int[] p_lista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerarNumero", ReplyAction="http://tempuri.org/IService1/GenerarNumeroResponse")]
        System.Threading.Tasks.Task<int> GenerarNumeroAsync(int p_iNumeroTecho, int[] p_lista);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Prueba.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Prueba.ServiceReference1.IService1>, Prueba.ServiceReference1.IService1 {
        
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
        
        public int GenerarNumero(int p_iNumeroTecho, int[] p_lista) {
            return base.Channel.GenerarNumero(p_iNumeroTecho, p_lista);
        }
        
        public System.Threading.Tasks.Task<int> GenerarNumeroAsync(int p_iNumeroTecho, int[] p_lista) {
            return base.Channel.GenerarNumeroAsync(p_iNumeroTecho, p_lista);
        }
    }
}
