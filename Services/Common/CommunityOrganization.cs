using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanerSnow.Common
{
    public class CommunityOrganization
    {
        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public List<CommunityEmployee> Employees { get; set; }
        public List<CommunityCommunication> Communications { get; set; }
    }
}
