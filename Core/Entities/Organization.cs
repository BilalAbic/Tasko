using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        // Navigation
        public ICollection<OrganizationUser> Users { get; set; }
        public ICollection<OrganizationInvite> Invites { get; set; }
    }
}
