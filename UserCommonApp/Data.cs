using System.Runtime.Serialization;

namespace UserCommonApp
{
    /// <summary>
    /// / It accepts request from client and returns the required data
    /// </summary>
    [DataContract]
    public class Data
    {
        [DataMember]
        public float VersionNumber { get; set; }

        [DataMember]
        public string URLMSI { get; set; }

        [DataMember]
        public bool MandatoryUpdate { get; set; }
    }
}
