﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaHtml.ServiceMantenedorDetalleReceta {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorDetalleReceta.WebServiceDetalleRecetaSoap")]
    public interface WebServiceDetalleRecetaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaDetalleRecetaService(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaDetalleRecetaServiceAsync(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarDetalleRecetaService(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarDetalleRecetaServiceAsync(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta retornaPosicionDetalleRecetaService(int pos, string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta> retornaPosicionDetalleRecetaServiceAsync(int pos, string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta buscarDetalleRecetaService(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta> buscarDetalleRecetaServiceAsync(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta buscarIdDetalleRecetaService(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta> buscarIdDetalleRecetaServiceAsync(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarDetalleRecetaService(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarDetalleRecetaServiceAsync(string id_detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarDetalleRecetaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarDetalleRecetaService(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarDetalleRecetaService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarDetalleRecetaServiceAsync(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class DetalleReceta : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_detalle_recetaField;
        
        private int cantidadField;
        
        private string paciente_rutField;
        
        private string formulario_medicamento_id_formularioField;
        
        private string medicamento_codigoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_detalle_receta {
            get {
                return this.id_detalle_recetaField;
            }
            set {
                this.id_detalle_recetaField = value;
                this.RaisePropertyChanged("Id_detalle_receta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
                this.RaisePropertyChanged("Cantidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Paciente_rut {
            get {
                return this.paciente_rutField;
            }
            set {
                this.paciente_rutField = value;
                this.RaisePropertyChanged("Paciente_rut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Formulario_medicamento_id_formulario {
            get {
                return this.formulario_medicamento_id_formularioField;
            }
            set {
                this.formulario_medicamento_id_formularioField = value;
                this.RaisePropertyChanged("Formulario_medicamento_id_formulario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Medicamento_codigo {
            get {
                return this.medicamento_codigoField;
            }
            set {
                this.medicamento_codigoField = value;
                this.RaisePropertyChanged("Medicamento_codigo");
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
    public interface WebServiceDetalleRecetaSoapChannel : CapaHtml.ServiceMantenedorDetalleReceta.WebServiceDetalleRecetaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceDetalleRecetaSoapClient : System.ServiceModel.ClientBase<CapaHtml.ServiceMantenedorDetalleReceta.WebServiceDetalleRecetaSoap>, CapaHtml.ServiceMantenedorDetalleReceta.WebServiceDetalleRecetaSoap {
        
        public WebServiceDetalleRecetaSoapClient() {
        }
        
        public WebServiceDetalleRecetaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceDetalleRecetaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDetalleRecetaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceDetalleRecetaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaDetalleRecetaService(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta) {
            base.Channel.insertaDetalleRecetaService(detalle_receta);
        }
        
        public System.Threading.Tasks.Task insertaDetalleRecetaServiceAsync(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta) {
            return base.Channel.insertaDetalleRecetaServiceAsync(detalle_receta);
        }
        
        public System.Data.DataSet retornarDetalleRecetaService(string id_detalle_receta) {
            return base.Channel.retornarDetalleRecetaService(id_detalle_receta);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarDetalleRecetaServiceAsync(string id_detalle_receta) {
            return base.Channel.retornarDetalleRecetaServiceAsync(id_detalle_receta);
        }
        
        public CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta retornaPosicionDetalleRecetaService(int pos, string id_detalle_receta) {
            return base.Channel.retornaPosicionDetalleRecetaService(pos, id_detalle_receta);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta> retornaPosicionDetalleRecetaServiceAsync(int pos, string id_detalle_receta) {
            return base.Channel.retornaPosicionDetalleRecetaServiceAsync(pos, id_detalle_receta);
        }
        
        public CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta buscarDetalleRecetaService(string id_detalle_receta) {
            return base.Channel.buscarDetalleRecetaService(id_detalle_receta);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta> buscarDetalleRecetaServiceAsync(string id_detalle_receta) {
            return base.Channel.buscarDetalleRecetaServiceAsync(id_detalle_receta);
        }
        
        public CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta buscarIdDetalleRecetaService(string id_detalle_receta) {
            return base.Channel.buscarIdDetalleRecetaService(id_detalle_receta);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta> buscarIdDetalleRecetaServiceAsync(string id_detalle_receta) {
            return base.Channel.buscarIdDetalleRecetaServiceAsync(id_detalle_receta);
        }
        
        public void eliminarDetalleRecetaService(string id_detalle_receta) {
            base.Channel.eliminarDetalleRecetaService(id_detalle_receta);
        }
        
        public System.Threading.Tasks.Task eliminarDetalleRecetaServiceAsync(string id_detalle_receta) {
            return base.Channel.eliminarDetalleRecetaServiceAsync(id_detalle_receta);
        }
        
        public void actualizarDetalleRecetaService(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta) {
            base.Channel.actualizarDetalleRecetaService(detalle_receta);
        }
        
        public System.Threading.Tasks.Task actualizarDetalleRecetaServiceAsync(CapaHtml.ServiceMantenedorDetalleReceta.DetalleReceta detalle_receta) {
            return base.Channel.actualizarDetalleRecetaServiceAsync(detalle_receta);
        }
    }
}