﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI_Bingo.miServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsJugador", Namespace="http://schemas.datacontract.org/2004/07/WCF_Bingo.Clases")]
    [System.SerializableAttribute()]
    public partial class clsJugador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UI_Bingo.miServicio.clsCarton[] ListaCartonesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NombreJugadorField;
        
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
        public UI_Bingo.miServicio.clsCarton[] ListaCartones {
            get {
                return this.ListaCartonesField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaCartonesField, value) != true)) {
                    this.ListaCartonesField = value;
                    this.RaisePropertyChanged("ListaCartones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NombreJugador {
            get {
                return this.NombreJugadorField;
            }
            set {
                if ((this.NombreJugadorField.Equals(value) != true)) {
                    this.NombreJugadorField = value;
                    this.RaisePropertyChanged("NombreJugador");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="clsCarton", Namespace="http://schemas.datacontract.org/2004/07/WCF_Bingo.Clases")]
    [System.SerializableAttribute()]
    public partial class clsCarton : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadNumerosAJugarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UI_Bingo.miServicio.clsCelda[][] ColumnasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroAReducirParaGanarField;
        
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
        public int CantidadNumerosAJugar {
            get {
                return this.CantidadNumerosAJugarField;
            }
            set {
                if ((this.CantidadNumerosAJugarField.Equals(value) != true)) {
                    this.CantidadNumerosAJugarField = value;
                    this.RaisePropertyChanged("CantidadNumerosAJugar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UI_Bingo.miServicio.clsCelda[][] Columnas {
            get {
                return this.ColumnasField;
            }
            set {
                if ((object.ReferenceEquals(this.ColumnasField, value) != true)) {
                    this.ColumnasField = value;
                    this.RaisePropertyChanged("Columnas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroAReducirParaGanar {
            get {
                return this.NumeroAReducirParaGanarField;
            }
            set {
                if ((this.NumeroAReducirParaGanarField.Equals(value) != true)) {
                    this.NumeroAReducirParaGanarField = value;
                    this.RaisePropertyChanged("NumeroAReducirParaGanar");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="clsCelda", Namespace="http://schemas.datacontract.org/2004/07/WCF_Bingo.Clases")]
    [System.SerializableAttribute()]
    public partial class clsCelda : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AJugarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroField;
        
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
        public bool AJugar {
            get {
                return this.AJugarField;
            }
            set {
                if ((this.AJugarField.Equals(value) != true)) {
                    this.AJugarField = value;
                    this.RaisePropertyChanged("AJugar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((this.NumeroField.Equals(value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="miServicio.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerarNumero", ReplyAction="http://tempuri.org/IService1/GenerarNumeroResponse")]
        int GenerarNumero(int p_iNumeroTecho, int[] p_lista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerarNumero", ReplyAction="http://tempuri.org/IService1/GenerarNumeroResponse")]
        System.Threading.Tasks.Task<int> GenerarNumeroAsync(int p_iNumeroTecho, int[] p_lista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/crearJugador", ReplyAction="http://tempuri.org/IService1/crearJugadorResponse")]
        UI_Bingo.miServicio.clsJugador[] crearJugador(UI_Bingo.miServicio.clsJugador[] listaJugadores, int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/crearJugador", ReplyAction="http://tempuri.org/IService1/crearJugadorResponse")]
        System.Threading.Tasks.Task<UI_Bingo.miServicio.clsJugador[]> crearJugadorAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/actualizarEstados", ReplyAction="http://tempuri.org/IService1/actualizarEstadosResponse")]
        UI_Bingo.miServicio.clsJugador[] actualizarEstados(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroAleatorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/actualizarEstados", ReplyAction="http://tempuri.org/IService1/actualizarEstadosResponse")]
        System.Threading.Tasks.Task<UI_Bingo.miServicio.clsJugador[]> actualizarEstadosAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroAleatorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/jugadoresGanadores", ReplyAction="http://tempuri.org/IService1/jugadoresGanadoresResponse")]
        UI_Bingo.miServicio.clsJugador[] jugadoresGanadores(UI_Bingo.miServicio.clsJugador[] listaJugadores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/jugadoresGanadores", ReplyAction="http://tempuri.org/IService1/jugadoresGanadoresResponse")]
        System.Threading.Tasks.Task<UI_Bingo.miServicio.clsJugador[]> jugadoresGanadoresAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultarCarton", ReplyAction="http://tempuri.org/IService1/consultarCartonResponse")]
        UI_Bingo.miServicio.clsCarton consultarCarton(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador, int indiceCarton);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultarCarton", ReplyAction="http://tempuri.org/IService1/consultarCartonResponse")]
        System.Threading.Tasks.Task<UI_Bingo.miServicio.clsCarton> consultarCartonAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador, int indiceCarton);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/cantidadJugadores", ReplyAction="http://tempuri.org/IService1/cantidadJugadoresResponse")]
        int cantidadJugadores(UI_Bingo.miServicio.clsJugador[] listaJugadores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/cantidadJugadores", ReplyAction="http://tempuri.org/IService1/cantidadJugadoresResponse")]
        System.Threading.Tasks.Task<int> cantidadJugadoresAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/cantidadCartonesPorJugador", ReplyAction="http://tempuri.org/IService1/cantidadCartonesPorJugadorResponse")]
        int cantidadCartonesPorJugador(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/cantidadCartonesPorJugador", ReplyAction="http://tempuri.org/IService1/cantidadCartonesPorJugadorResponse")]
        System.Threading.Tasks.Task<int> cantidadCartonesPorJugadorAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : UI_Bingo.miServicio.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<UI_Bingo.miServicio.IService1>, UI_Bingo.miServicio.IService1 {
        
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
        
        public UI_Bingo.miServicio.clsJugador[] crearJugador(UI_Bingo.miServicio.clsJugador[] listaJugadores, int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad) {
            return base.Channel.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);
        }
        
        public System.Threading.Tasks.Task<UI_Bingo.miServicio.clsJugador[]> crearJugadorAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad) {
            return base.Channel.crearJugadorAsync(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);
        }
        
        public UI_Bingo.miServicio.clsJugador[] actualizarEstados(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroAleatorio) {
            return base.Channel.actualizarEstados(listaJugadores, numeroAleatorio);
        }
        
        public System.Threading.Tasks.Task<UI_Bingo.miServicio.clsJugador[]> actualizarEstadosAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroAleatorio) {
            return base.Channel.actualizarEstadosAsync(listaJugadores, numeroAleatorio);
        }
        
        public UI_Bingo.miServicio.clsJugador[] jugadoresGanadores(UI_Bingo.miServicio.clsJugador[] listaJugadores) {
            return base.Channel.jugadoresGanadores(listaJugadores);
        }
        
        public System.Threading.Tasks.Task<UI_Bingo.miServicio.clsJugador[]> jugadoresGanadoresAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores) {
            return base.Channel.jugadoresGanadoresAsync(listaJugadores);
        }
        
        public UI_Bingo.miServicio.clsCarton consultarCarton(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador, int indiceCarton) {
            return base.Channel.consultarCarton(listaJugadores, numeroJugador, indiceCarton);
        }
        
        public System.Threading.Tasks.Task<UI_Bingo.miServicio.clsCarton> consultarCartonAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador, int indiceCarton) {
            return base.Channel.consultarCartonAsync(listaJugadores, numeroJugador, indiceCarton);
        }
        
        public int cantidadJugadores(UI_Bingo.miServicio.clsJugador[] listaJugadores) {
            return base.Channel.cantidadJugadores(listaJugadores);
        }
        
        public System.Threading.Tasks.Task<int> cantidadJugadoresAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores) {
            return base.Channel.cantidadJugadoresAsync(listaJugadores);
        }
        
        public int cantidadCartonesPorJugador(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador) {
            return base.Channel.cantidadCartonesPorJugador(listaJugadores, numeroJugador);
        }
        
        public System.Threading.Tasks.Task<int> cantidadCartonesPorJugadorAsync(UI_Bingo.miServicio.clsJugador[] listaJugadores, int numeroJugador) {
            return base.Channel.cantidadCartonesPorJugadorAsync(listaJugadores, numeroJugador);
        }
    }
}
