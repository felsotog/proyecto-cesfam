﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaServicioCesfam.ServiceFarmaceutico {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceFarmaceutico.WebServiceFarmaceuticoSoap")]
    public interface WebServiceFarmaceuticoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaFarmaceuticoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaFarmaceuticoService(CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico auxFarmaceutico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaFarmaceuticoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaFarmaceuticoServiceAsync(CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico auxFarmaceutico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarFarmaceuticoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarFarmaceuticoService(string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarFarmaceuticoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarFarmaceuticoServiceAsync(string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionFarmaceuticoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico retornaPosicionFarmaceuticoService(int pos, string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionFarmaceuticoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico> retornaPosicionFarmaceuticoServiceAsync(int pos, string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarFarmaceuticoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico buscarFarmaceuticoService(string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarFarmaceuticoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico> buscarFarmaceuticoServiceAsync(string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdFarmaceuticoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico buscarIdFarmaceuticoService(string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdFarmaceuticoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico> buscarIdFarmaceuticoServiceAsync(string id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarFarmaciaService(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarFarmaciaServiceAsync(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarCiudadService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarCiudadService(CapaServicioCesfam.ServiceFarmaceutico.Farmacia farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarCiudadService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarCiudadServiceAsync(CapaServicioCesfam.ServiceFarmaceutico.Farmacia farmacia);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Farmaceutico : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_ciudadField;
        
        private string nombre_farmaceutaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_ciudad {
            get {
                return this.id_ciudadField;
            }
            set {
                this.id_ciudadField = value;
                this.RaisePropertyChanged("Id_ciudad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre_farmaceuta {
            get {
                return this.nombre_farmaceutaField;
            }
            set {
                this.nombre_farmaceutaField = value;
                this.RaisePropertyChanged("Nombre_farmaceuta");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Farmacia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_farmaciaField;
        
        private string id_ciudadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_farmacia {
            get {
                return this.id_farmaciaField;
            }
            set {
                this.id_farmaciaField = value;
                this.RaisePropertyChanged("Id_farmacia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Id_ciudad {
            get {
                return this.id_ciudadField;
            }
            set {
                this.id_ciudadField = value;
                this.RaisePropertyChanged("Id_ciudad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
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
    public interface WebServiceFarmaceuticoSoapChannel : CapaServicioCesfam.ServiceFarmaceutico.WebServiceFarmaceuticoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFarmaceuticoSoapClient : System.ServiceModel.ClientBase<CapaServicioCesfam.ServiceFarmaceutico.WebServiceFarmaceuticoSoap>, CapaServicioCesfam.ServiceFarmaceutico.WebServiceFarmaceuticoSoap {
        
        public WebServiceFarmaceuticoSoapClient() {
        }
        
        public WebServiceFarmaceuticoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFarmaceuticoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFarmaceuticoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFarmaceuticoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaFarmaceuticoService(CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico auxFarmaceutico) {
            base.Channel.insertaFarmaceuticoService(auxFarmaceutico);
        }
        
        public System.Threading.Tasks.Task insertaFarmaceuticoServiceAsync(CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico auxFarmaceutico) {
            return base.Channel.insertaFarmaceuticoServiceAsync(auxFarmaceutico);
        }
        
        public System.Data.DataSet retornarFarmaceuticoService(string id_ciudad) {
            return base.Channel.retornarFarmaceuticoService(id_ciudad);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarFarmaceuticoServiceAsync(string id_ciudad) {
            return base.Channel.retornarFarmaceuticoServiceAsync(id_ciudad);
        }
        
        public CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico retornaPosicionFarmaceuticoService(int pos, string id_ciudad) {
            return base.Channel.retornaPosicionFarmaceuticoService(pos, id_ciudad);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico> retornaPosicionFarmaceuticoServiceAsync(int pos, string id_ciudad) {
            return base.Channel.retornaPosicionFarmaceuticoServiceAsync(pos, id_ciudad);
        }
        
        public CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico buscarFarmaceuticoService(string id_ciudad) {
            return base.Channel.buscarFarmaceuticoService(id_ciudad);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico> buscarFarmaceuticoServiceAsync(string id_ciudad) {
            return base.Channel.buscarFarmaceuticoServiceAsync(id_ciudad);
        }
        
        public CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico buscarIdFarmaceuticoService(string id_ciudad) {
            return base.Channel.buscarIdFarmaceuticoService(id_ciudad);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmaceutico.Farmaceutico> buscarIdFarmaceuticoServiceAsync(string id_ciudad) {
            return base.Channel.buscarIdFarmaceuticoServiceAsync(id_ciudad);
        }
        
        public void eliminarFarmaciaService(string id_farmacia) {
            base.Channel.eliminarFarmaciaService(id_farmacia);
        }
        
        public System.Threading.Tasks.Task eliminarFarmaciaServiceAsync(string id_farmacia) {
            return base.Channel.eliminarFarmaciaServiceAsync(id_farmacia);
        }
        
        public void actualizarCiudadService(CapaServicioCesfam.ServiceFarmaceutico.Farmacia farmacia) {
            base.Channel.actualizarCiudadService(farmacia);
        }
        
        public System.Threading.Tasks.Task actualizarCiudadServiceAsync(CapaServicioCesfam.ServiceFarmaceutico.Farmacia farmacia) {
            return base.Channel.actualizarCiudadServiceAsync(farmacia);
        }
    }
}
