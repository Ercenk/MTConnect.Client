/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:mtconnect.org:MTConnectStreams:1.3")]
public partial class HeaderType {
    
    private string versionField;
    
    private System.DateTime creationTimeField;
    
    private string nextSequenceField;
    
    private string lastSequenceField;
    
    private string firstSequenceField;
    
    private bool testIndicatorField;
    
    private bool testIndicatorFieldSpecified;
    
    private string instanceIdField;
    
    private string senderField;
    
    private string bufferSizeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime creationTime {
        get {
            return this.creationTimeField;
        }
        set {
            this.creationTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string nextSequence {
        get {
            return this.nextSequenceField;
        }
        set {
            this.nextSequenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string lastSequence {
        get {
            return this.lastSequenceField;
        }
        set {
            this.lastSequenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string firstSequence {
        get {
            return this.firstSequenceField;
        }
        set {
            this.firstSequenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool testIndicator {
        get {
            return this.testIndicatorField;
        }
        set {
            this.testIndicatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool testIndicatorSpecified {
        get {
            return this.testIndicatorFieldSpecified;
        }
        set {
            this.testIndicatorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string instanceId {
        get {
            return this.instanceIdField;
        }
        set {
            this.instanceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sender {
        get {
            return this.senderField;
        }
        set {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string bufferSize {
        get {
            return this.bufferSizeField;
        }
        set {
            this.bufferSizeField = value;
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