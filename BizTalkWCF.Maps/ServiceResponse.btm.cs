namespace BizTalkWCF.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere+GetDataUsingDataContractResponse", typeof(global::BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere.GetDataUsingDataContractResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkWCF.Schemas.BizTalkServiceResponse", typeof(global::BizTalkWCF.Schemas.BizTalkServiceResponse))]
    public sealed class ServiceResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s0=""http://schemas.datacontract.org/2004/07/WcfService"" xmlns:ns0=""http://BizTalkWCF.Schemas.BizTalkServiceResponse"" xmlns:s1=""YourNameSpaceHere"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:GetDataUsingDataContractResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:GetDataUsingDataContractResponse"">
    <ns0:Root>
      <xsl:if test=""s1:GetDataUsingDataContractResult/s0:StringValue"">
        <ResponseMessage>
          <xsl:value-of select=""s1:GetDataUsingDataContractResult/s0:StringValue/text()"" />
        </ResponseMessage>
      </xsl:if>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere+GetDataUsingDataContractResponse";
        
        private const global::BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere.GetDataUsingDataContractResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkWCF.Schemas.BizTalkServiceResponse";
        
        private const global::BizTalkWCF.Schemas.BizTalkServiceResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkWCF.WcfPorts.MyService_YourNameSpaceHere+GetDataUsingDataContractResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkWCF.Schemas.BizTalkServiceResponse";
                return _TrgSchemas;
            }
        }
    }
}
