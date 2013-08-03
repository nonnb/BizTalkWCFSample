using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract(Namespace = "YourNameSpaceHere")]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        SomeSerializableEntity GetDataUsingDataContract(SomeSerializableEntity composite);
    }

    [DataContract]
    public class SomeSerializableEntity
    {
        private bool _boolValue = true;
        private string _stringValue = "Hello World";

        [DataMember]
        public bool BoolValue
        {
            get { return _boolValue; }
            set { _boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return _stringValue; }
            set { _stringValue = value; }
        }
    }
}
