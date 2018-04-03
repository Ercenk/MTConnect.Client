﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:mtconnect.org:MTConnectError:1.3")]
[System.Xml.Serialization.XmlRootAttribute("MTConnectError", Namespace="urn:mtconnect.org:MTConnectError:1.3", IsNullable=false)]
public partial class MTConnectErrorType {
    
    private HeaderType headerField;
    
    private object itemField;
    
    /// <remarks/>
    public HeaderType Header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error", typeof(ErrorType))]
    [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:mtconnect.org:MTConnectError:1.3")]
public partial class ErrorsType {
    
    private ErrorType[] errorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error")]
    public ErrorType[] Error {
        get {
            return this.errorField;
        }
        set {
            this.errorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:mtconnect.org:MTConnectError:1.3")]
public partial class ErrorType {
    
    private ErrorCodeType errorCodeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ErrorCodeType errorCode {
        get {
            return this.errorCodeField;
        }
        set {
            this.errorCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:mtconnect.org:MTConnectError:1.3")]
public enum ErrorCodeType {
    
    /// <remarks/>
    UNAUTHORIZED,
    
    /// <remarks/>
    NO_DEVICE,
    
    /// <remarks/>
    OUT_OF_RANGE,
    
    /// <remarks/>
    TOO_MANY,
    
    /// <remarks/>
    INVALID_URI,
    
    /// <remarks/>
    INVALID_REQUEST,
    
    /// <remarks/>
    INTERNAL_ERROR,
    
    /// <remarks/>
    INVALID_PATH,
    
    /// <remarks/>
    UNSUPPORTED,
    
    /// <remarks/>
    ASSET_NOT_FOUND,
}
