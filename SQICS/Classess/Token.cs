using System.Runtime.Serialization;

namespace SQICS.Classess
{
    [DataContract]
    public class Token
    {
        [DataMember]
        public string access_token { get; set; }
        [DataMember]
        public int expires_in { get; set; }
        [DataMember]
        public int refresh_expires_in { get; set; }
        [DataMember]
        public string refresh_token { get; set; }
        [DataMember]
        public string token_type { get; set; }
        [DataMember]
        public string id_token { get; set; }
        [DataMember]
        public int not_before_policy { get; set; }
        [DataMember]
        public string session_state { get; set; }
        [DataMember]
        public string scope { get; set; }
    }
}
