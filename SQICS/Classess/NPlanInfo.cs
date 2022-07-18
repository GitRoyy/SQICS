using System.Runtime.Serialization;

namespace SQICS.Classess
{
    [DataContract]
    public class NPlanInfo
    {
        [DataMember]
        public string AssyCode { get; set; }

        [DataMember]
        public string id { get; set; }
    }
}
