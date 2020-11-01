using System.Runtime.Serialization;

namespace UserCommonApp
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public int Error_code { get; set; }

        [DataMember]
        public bool MandatoryUpdate { get; set; }

        [DataMember]
        public string CurrentStableVersion { get; set; }

        [DataMember]
        public string latestVersionLink { get; set; }
    }
}
