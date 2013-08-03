namespace BizTalkWCF.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkWCF.Schemas.BizTalkServiceRequest", typeof(global::BizTalkWCF.Schemas.BizTalkServiceRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere+GetDataUsingDataContract", typeof(global::BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere.GetDataUsingDataContract))]
    public sealed class ServiceRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalkWCF.Schemas.BizTalkServiceRequest"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/WcfService"" xmlns:ns0=""YourNameSpaceHere"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:GetDataUsingDataContract>
      <ns0:composite>
        <ns1:BoolValue>
          <xsl:value-of select=""IsAddSuffix/text()"" />
        </ns1:BoolValue>
        <ns1:StringValue>
          <xsl:value-of select=""Name/text()"" />
        </ns1:StringValue>
      </ns0:composite>
    </ns0:GetDataUsingDataContract>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkWCF.Schemas.BizTalkServiceRequest";
        
        private const global::BizTalkWCF.Schemas.BizTalkServiceRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere+GetDataUsingDataContract";
        
        private const global::BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere.GetDataUsingDataContract _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalkWCF.Schemas.BizTalkServiceRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere+GetDataUsingDataContract";
                return _TrgSchemas;
            }
        }
    }
}
