﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace CTe.v300 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IsNullable=false)]
    public partial class evRegMultimodal : object, System.ComponentModel.INotifyPropertyChanged {
        
        private evRegMultimodalDescEvento descEventoField;
        
        private string xRegistroField;
        
        private string nDocField;
        
        /// <remarks/>
        public evRegMultimodalDescEvento descEvento {
            get {
                return this.descEventoField;
            }
            set {
                this.descEventoField = value;
                this.RaisePropertyChanged("descEvento");
            }
        }
        
        /// <remarks/>
        public string xRegistro {
            get {
                return this.xRegistroField;
            }
            set {
                this.xRegistroField = value;
                this.RaisePropertyChanged("xRegistro");
            }
        }
        
        /// <remarks/>
        public string nDoc {
            get {
                return this.nDocField;
            }
            set {
                this.nDocField = value;
                this.RaisePropertyChanged("nDoc");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public enum evRegMultimodalDescEvento {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Registro Multimodal")]
        RegistroMultimodal,
    }
}
