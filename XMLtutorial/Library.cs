﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Library {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/library")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://example.org/jk/library", IsNullable=false)]
    public partial class library {
        
        private libraryBook[] bookField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("book")]
        public libraryBook[] book {
            get {
                return this.bookField;
            }
            set {
                this.bookField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/library")]
    public partial class libraryBook {
        
        private libraryBookAuthor[] authorField;
        
        private string titleField;
        
        private libraryBookLanguage languageField;
        
        private string yearField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public libraryBookAuthor[] author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public libraryBookLanguage language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        public string year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/library")]
    public partial class libraryBookAuthor {
        
        private string[] nameField;
        
        private string surnameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/library")]
    public enum libraryBookLanguage {
        
        /// <remarks/>
        PL,
        
        /// <remarks/>
        EN,
        
        /// <remarks/>
        RU,
    }
}