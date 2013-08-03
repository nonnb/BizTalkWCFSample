using System.Diagnostics.Contracts;
using System.ServiceModel;

namespace WcfService
{
    [ServiceBehavior(Namespace = "YourNameSpaceHere")]
    public class MyService : IService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public SomeSerializableEntity GetDataUsingDataContract(SomeSerializableEntity entity)
        {
            Contract.Requires(entity != null);

            if (entity.BoolValue)
            {
                entity.StringValue += " Suffix";
            }
            return entity;
        }
    }
}
