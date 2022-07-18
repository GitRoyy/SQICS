using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SQICS.Classess
{
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string sub { get; set; }
        [DataMember]
        public bool email_verified { get; set; }
        [DataMember]
        public int supplier { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string preferred_username { get; set; }
        [DataMember]
        public string given_name { get; set; }
        [DataMember]
        public string family_name { get; set; }


    }
}
