using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Navigation
        public ICollection<OrganizationUser> Organizations { get; set; }
    }
}
