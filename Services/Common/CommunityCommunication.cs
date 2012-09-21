using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanerSnow.Common
{
    public class CommunityCommunication
    {
        public int CommunicationID { get; set; }
        public bool Followup { get; set; }
        public string IPMEmployee { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string OrgEmployee { get; set; }
        public string Notes { get; set; }
    }
}
