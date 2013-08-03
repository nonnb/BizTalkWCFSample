namespace BizTalkWCF.WcfPorts {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetData", @"GetDataResponse", @"GetDataUsingDataContract", @"GetDataUsingDataContractResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkWCF.WcfPorts.MyService_schemas_datacontract_org_2004_07_WcfService", typeof(global::BizTalkWCF.WcfPorts.MyService_schemas_datacontract_org_2004_07_WcfService))]
    public sealed class MyService_YourNameSpaceHere : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""YourNameSpaceHere"" elementFormDefault=""qualified"" targetNamespace=""YourNameSpaceHere"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BizTalkWCF.WcfPorts.MyService_schemas_datacontract_org_2004_07_WcfService"" namespace=""http://schemas.datacontract.org/2004/07/WcfService"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/WcfService"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""GetData"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""value"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetDataResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""GetDataResult"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetDataUsingDataContract"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/WcfService"" minOccurs=""0"" name=""composite"" nillable=""true"" type=""q1:SomeSerializableEntity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetDataUsingDataContractResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/WcfService"" minOccurs=""0"" name=""GetDataUsingDataContractResult"" nillable=""true"" type=""q2:SomeSerializableEntity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MyService_YourNameSpaceHere() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "GetData";
                _RootElements[1] = "GetDataResponse";
                _RootElements[2] = "GetDataUsingDataContract";
                _RootElements[3] = "GetDataUsingDataContractResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"YourNameSpaceHere",@"GetData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetData"})]
        public sealed class GetData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetData";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"YourNameSpaceHere",@"GetDataResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetDataResponse"})]
        public sealed class GetDataResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetDataResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetDataResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"YourNameSpaceHere",@"GetDataUsingDataContract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetDataUsingDataContract"})]
        public sealed class GetDataUsingDataContract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetDataUsingDataContract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetDataUsingDataContract";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"YourNameSpaceHere",@"GetDataUsingDataContractResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GetDataUsingDataContractResponse"})]
        public sealed class GetDataUsingDataContractResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GetDataUsingDataContractResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GetDataUsingDataContractResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
