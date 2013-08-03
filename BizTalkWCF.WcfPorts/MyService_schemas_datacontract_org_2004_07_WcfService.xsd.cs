namespace BizTalkWCF.WcfPorts {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.datacontract.org/2004/07/WcfService",@"SomeSerializableEntity")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SomeSerializableEntity"})]
    public sealed class MyService_schemas_datacontract_org_2004_07_WcfService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/WcfService"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/WcfService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""SomeSerializableEntity"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BoolValue"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""StringValue"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""SomeSerializableEntity"" nillable=""true"" type=""tns:SomeSerializableEntity"" />
</xs:schema>";
        
        public MyService_schemas_datacontract_org_2004_07_WcfService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SomeSerializableEntity";
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
