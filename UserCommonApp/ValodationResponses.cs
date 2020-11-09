using System.Runtime.Serialization;
using Ziroh.Misc.Common;

namespace UserCommonApp
{
    [DataContract]
    public class ValidationResponse: Result
    {

        [DataMember]
        public bool MandatoryUpdate { get; set; }

        [DataMember]
        public string CurrentStableVersion { get; set; }

        [DataMember]
        public string latestVersionLink { get; set; }
    }
}
