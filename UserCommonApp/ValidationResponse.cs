using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Ziroh.Misc.Common;

namespace UserCommonApp
{
    [DataContract]
    public class ValidationResponse : Result
    {
        [DataMember]
        public bool isUpdateAvailable { get; set; }

        [DataMember]
        public bool MandatoryUpdate { get; set; }

        [DataMember]
        public string CurrentStableVersion { get; set; }

        [DataMember]
        public string latestVersionLink { get; set; }

        [DataMember]
        public string UpgradeReferenceId { get; set; }

        [DataMember]
        public DateTimeFormat ReleaseDate { get; set; }
    }
}
