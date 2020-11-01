using System.Runtime.Serialization;

namespace UserCommonApp
{
    [DataContract]
    public class Data
    {
        [DataMember]
        public float appVersion { get; set; }

        [DataMember]
        public string versionUpdateLink { get; set; }
    }
}
