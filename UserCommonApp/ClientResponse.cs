using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserCommonApp
{
    [DataContract]
    public class ClientResponse
    {
        [DataMember]
        public string ClientVersionNumber { get; set; }

        [DataMember]
        public string clientPlatform { get; set; }

        [DataMember]
        public bool is64Bit { get; set; }
    }
}
