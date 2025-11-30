using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrganizationInvite
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public int MaxUses { get; set; }
        public int Uses { get; set; }

        public Organization Organization { get; set; }
    }
}
