﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFin.Migrate.NFSe.WebService.Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiCy", Namespace="InvoiCy")]
    [System.SerializableAttribute()]
    public partial class InvoiCy : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRecepcaoCabecalho CabecalhoField;
        
        private SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRecepcaoInformacoes InformacoesField;
        
        private SoftFin.Migrate.NFSe.WebService.Service.InvoiCy.DadosType DadosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRecepcaoCabecalho Cabecalho {
            get {
                return this.CabecalhoField;
            }
            set {
                if ((object.ReferenceEquals(this.CabecalhoField, value) != true)) {
                    this.CabecalhoField = value;
                    this.RaisePropertyChanged("Cabecalho");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRecepcaoInformacoes Informacoes {
            get {
                return this.InformacoesField;
            }
            set {
                if ((object.ReferenceEquals(this.InformacoesField, value) != true)) {
                    this.InformacoesField = value;
                    this.RaisePropertyChanged("Informacoes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=2)]
        public SoftFin.Migrate.NFSe.WebService.Service.InvoiCy.DadosType Dados {
            get {
                return this.DadosField;
            }
            set {
                if ((object.ReferenceEquals(this.DadosField, value) != true)) {
                    this.DadosField = value;
                    this.RaisePropertyChanged("Dados");
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
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.CollectionDataContractAttribute(Name="InvoiCy.DadosType", Namespace="InvoiCy", ItemName="DadosItem")]
        [System.SerializableAttribute()]
        public class DadosType : System.Collections.Generic.List<SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRecepcaoDadosItem> {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiCyRecepcao.Cabecalho", Namespace="InvoiCy")]
    [System.SerializableAttribute()]
    public partial class InvoiCyRecepcaoCabecalho : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string EmpPKField;
        
        private string EmpCKField;
        
        private string EmpCOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string EmpPK {
            get {
                return this.EmpPKField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpPKField, value) != true)) {
                    this.EmpPKField = value;
                    this.RaisePropertyChanged("EmpPK");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=1)]
        public string EmpCK {
            get {
                return this.EmpCKField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpCKField, value) != true)) {
                    this.EmpCKField = value;
                    this.RaisePropertyChanged("EmpCK");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=2)]
        public string EmpCO {
            get {
                return this.EmpCOField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpCOField, value) != true)) {
                    this.EmpCOField = value;
                    this.RaisePropertyChanged("EmpCO");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiCyRecepcao.Informacoes", Namespace="InvoiCy")]
    [System.SerializableAttribute()]
    public partial class InvoiCyRecepcaoInformacoes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string TextoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Texto {
            get {
                return this.TextoField;
            }
            set {
                if ((object.ReferenceEquals(this.TextoField, value) != true)) {
                    this.TextoField = value;
                    this.RaisePropertyChanged("Texto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiCyRecepcao.DadosItem", Namespace="InvoiCy")]
    [System.SerializableAttribute()]
    public partial class InvoiCyRecepcaoDadosItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DocumentoField;
        
        private string ParametrosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Documento {
            get {
                return this.DocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentoField, value) != true)) {
                    this.DocumentoField = value;
                    this.RaisePropertyChanged("Documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Parametros {
            get {
                return this.ParametrosField;
            }
            set {
                if ((object.ReferenceEquals(this.ParametrosField, value) != true)) {
                    this.ParametrosField = value;
                    this.RaisePropertyChanged("Parametros");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Invoicyretorno", Namespace="InvoiCy")]
    [System.SerializableAttribute()]
    public partial class Invoicyretorno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private SoftFin.Migrate.NFSe.WebService.Service.Invoicyretorno.MensagemType MensagemField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SoftFin.Migrate.NFSe.WebService.Service.Invoicyretorno.MensagemType Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
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
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Invoicyretorno.MensagemType", Namespace="InvoiCy", ItemName="MensagemItem")]
        [System.SerializableAttribute()]
        public class MensagemType : System.Collections.Generic.List<SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRetornoMensagemItem> {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiCyRetorno.MensagemItem", Namespace="InvoiCy")]
    [System.SerializableAttribute()]
    public partial class InvoiCyRetornoMensagemItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CodigoField;
        
        private string DescricaoField;
        
        private SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRetornoMensagemItem.DocumentosType DocumentosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRetornoMensagemItem.DocumentosType Documentos {
            get {
                return this.DocumentosField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentosField, value) != true)) {
                    this.DocumentosField = value;
                    this.RaisePropertyChanged("Documentos");
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
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.CollectionDataContractAttribute(Name="InvoiCyRetorno.MensagemItem.DocumentosType", Namespace="InvoiCy", ItemName="DocumentosItem")]
        [System.SerializableAttribute()]
        public class DocumentosType : System.Collections.Generic.List<SoftFin.Migrate.NFSe.WebService.Service.InvoiCyRetornoMensagemItem.DocumentosItem> {
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="InvoiCyRetorno.MensagemItem.DocumentosItem", Namespace="InvoiCy")]
        [System.SerializableAttribute()]
        public partial class DocumentosItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            private string DocumentoField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
            public string Documento {
                get {
                    return this.DocumentoField;
                }
                set {
                    if ((object.ReferenceEquals(this.DocumentoField, value) != true)) {
                        this.DocumentoField = value;
                        this.RaisePropertyChanged("Documento");
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="InvoiCy", ConfigurationName="Service.recepcaoSoapPort")]
    public interface recepcaoSoapPort {
        
        // CODEGEN: Generating message contract since the wrapper name (recepcao.Execute) of message ExecuteRequest does not match the default value (Execute)
        [System.ServiceModel.OperationContractAttribute(Action="InvoiCyaction/ARECEPCAO.Execute", ReplyAction="*")]
        SoftFin.Migrate.NFSe.WebService.Service.ExecuteResponse Execute(SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="InvoiCyaction/ARECEPCAO.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<SoftFin.Migrate.NFSe.WebService.Service.ExecuteResponse> ExecuteAsync(SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="recepcao.Execute", WrapperNamespace="InvoiCy", IsWrapped=true)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="InvoiCy", Order=0)]
        public SoftFin.Migrate.NFSe.WebService.Service.InvoiCy Invoicyrecepcao;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(SoftFin.Migrate.NFSe.WebService.Service.InvoiCy Invoicyrecepcao) {
            this.Invoicyrecepcao = Invoicyrecepcao;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="recepcao.ExecuteResponse", WrapperNamespace="InvoiCy", IsWrapped=true)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="InvoiCy", Order=0)]
        public SoftFin.Migrate.NFSe.WebService.Service.Invoicyretorno Invoicyretorno;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(SoftFin.Migrate.NFSe.WebService.Service.Invoicyretorno Invoicyretorno) {
            this.Invoicyretorno = Invoicyretorno;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface recepcaoSoapPortChannel : SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class recepcaoSoapPortClient : System.ServiceModel.ClientBase<SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort>, SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort {
        
        public recepcaoSoapPortClient() {
        }
        
        public recepcaoSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public recepcaoSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public recepcaoSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public recepcaoSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoftFin.Migrate.NFSe.WebService.Service.ExecuteResponse SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort.Execute(SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public SoftFin.Migrate.NFSe.WebService.Service.Invoicyretorno Execute(SoftFin.Migrate.NFSe.WebService.Service.InvoiCy Invoicyrecepcao) {
            SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest inValue = new SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest();
            inValue.Invoicyrecepcao = Invoicyrecepcao;
            SoftFin.Migrate.NFSe.WebService.Service.ExecuteResponse retVal = ((SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort)(this)).Execute(inValue);
            return retVal.Invoicyretorno;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoftFin.Migrate.NFSe.WebService.Service.ExecuteResponse> SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort.ExecuteAsync(SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoftFin.Migrate.NFSe.WebService.Service.ExecuteResponse> ExecuteAsync(SoftFin.Migrate.NFSe.WebService.Service.InvoiCy Invoicyrecepcao) {
            SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest inValue = new SoftFin.Migrate.NFSe.WebService.Service.ExecuteRequest();
            inValue.Invoicyrecepcao = Invoicyrecepcao;
            return ((SoftFin.Migrate.NFSe.WebService.Service.recepcaoSoapPort)(this)).ExecuteAsync(inValue);
        }
    }
}
