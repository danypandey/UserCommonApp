using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Ziroh.Misc.Common;

namespace UserCommonApp
{
    [DataContract]
    public class ValidationResponse: Result
    {
        [DataMember]
        public string ClientVersionNumber { get; set; }

        [DataMember]
        public bool MandatoryUpdate { get; set; }

        [DataMember]
        public string CurrentStableVersion { get; set; }

        [DataMember]
        public string latestVersionLink { get; set; }

        [DataMember]
        public string clientPlatform { get; set; }

        [DataMember]
        public string ClientOS_Bit { get; set; }
    }
}
