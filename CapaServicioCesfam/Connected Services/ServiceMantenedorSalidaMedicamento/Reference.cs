﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaServicioCesfam.ServiceMantenedorSalidaMedicamento {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorSalidaMedicamento.WebServiceSalidaMedicamentoSoap")]
    public interface WebServiceSalidaMedicamentoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaSalidaMedicamentoService(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento auxSalidaMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaSalidaMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento auxSalidaMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarSalidaMedicamentoService(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarSalidaMedicamentoServiceAsync(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento retornaPosicionSalidaMedicamentoService(int pos, string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento> retornaPosicionSalidaMedicamentoServiceAsync(int pos, string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento buscarSalidaMedicamentoService(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento> buscarSalidaMedicamentoServiceAsync(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento buscarIdSalidaMedicamentoService(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento> buscarIdSalidaMedicamentoServiceAsync(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarSalidaMedicamentoService(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarSalidaMedicamentoServiceAsync(string id_salida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarSalidaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarSalidaMedicamentoService(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento salida_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarSalidaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarSalidaMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento salida_medicamento);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SalidaMedicamento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_salidaField;
        
        private System.DateTime fecha_salidaField;
        
        private string farmaceutico_id_farmaceutaField;
        
        private string paciente_rutField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_salida {
            get {
                return this.id_salidaField;
            }
            set {
                this.id_salidaField = value;
                this.RaisePropertyChanged("Id_salida");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Fecha_salida {
            get {
                return this.fecha_salidaField;
            }
            set {
                this.fecha_salidaField = value;
                this.RaisePropertyChanged("Fecha_salida");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Farmaceutico_id_farmaceuta {
            get {
                return this.farmaceutico_id_farmaceutaField;
            }
            set {
                this.farmaceutico_id_farmaceutaField = value;
                this.RaisePropertyChanged("Farmaceutico_id_farmaceuta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Paciente_rut {
            get {
                return this.paciente_rutField;
            }
            set {
                this.paciente_rutField = value;
                this.RaisePropertyChanged("Paciente_rut");
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
    public interface WebServiceSalidaMedicamentoSoapChannel : CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.WebServiceSalidaMedicamentoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSalidaMedicamentoSoapClient : System.ServiceModel.ClientBase<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.WebServiceSalidaMedicamentoSoap>, CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.WebServiceSalidaMedicamentoSoap {
        
        public WebServiceSalidaMedicamentoSoapClient() {
        }
        
        public WebServiceSalidaMedicamentoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSalidaMedicamentoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSalidaMedicamentoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSalidaMedicamentoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaSalidaMedicamentoService(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento auxSalidaMedicamento) {
            base.Channel.insertaSalidaMedicamentoService(auxSalidaMedicamento);
        }
        
        public System.Threading.Tasks.Task insertaSalidaMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento auxSalidaMedicamento) {
            return base.Channel.insertaSalidaMedicamentoServiceAsync(auxSalidaMedicamento);
        }
        
        public System.Data.DataSet retornarSalidaMedicamentoService(string id_salida) {
            return base.Channel.retornarSalidaMedicamentoService(id_salida);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarSalidaMedicamentoServiceAsync(string id_salida) {
            return base.Channel.retornarSalidaMedicamentoServiceAsync(id_salida);
        }
        
        public CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento retornaPosicionSalidaMedicamentoService(int pos, string id_salida) {
            return base.Channel.retornaPosicionSalidaMedicamentoService(pos, id_salida);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento> retornaPosicionSalidaMedicamentoServiceAsync(int pos, string id_salida) {
            return base.Channel.retornaPosicionSalidaMedicamentoServiceAsync(pos, id_salida);
        }
        
        public CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento buscarSalidaMedicamentoService(string id_salida) {
            return base.Channel.buscarSalidaMedicamentoService(id_salida);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento> buscarSalidaMedicamentoServiceAsync(string id_salida) {
            return base.Channel.buscarSalidaMedicamentoServiceAsync(id_salida);
        }
        
        public CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento buscarIdSalidaMedicamentoService(string id_salida) {
            return base.Channel.buscarIdSalidaMedicamentoService(id_salida);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento> buscarIdSalidaMedicamentoServiceAsync(string id_salida) {
            return base.Channel.buscarIdSalidaMedicamentoServiceAsync(id_salida);
        }
        
        public void eliminarSalidaMedicamentoService(string id_salida) {
            base.Channel.eliminarSalidaMedicamentoService(id_salida);
        }
        
        public System.Threading.Tasks.Task eliminarSalidaMedicamentoServiceAsync(string id_salida) {
            return base.Channel.eliminarSalidaMedicamentoServiceAsync(id_salida);
        }
        
        public void actualizarSalidaMedicamentoService(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento salida_medicamento) {
            base.Channel.actualizarSalidaMedicamentoService(salida_medicamento);
        }
        
        public System.Threading.Tasks.Task actualizarSalidaMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorSalidaMedicamento.SalidaMedicamento salida_medicamento) {
            return base.Channel.actualizarSalidaMedicamentoServiceAsync(salida_medicamento);
        }
    }
}
