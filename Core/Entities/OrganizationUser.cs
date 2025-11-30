using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrganizationUser
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int UserId { get; set; }
        public string Role { get; set; }

        // Navigation
        public Organization Organization { get; set; }
        public Users User { get; set; }
    }
}
