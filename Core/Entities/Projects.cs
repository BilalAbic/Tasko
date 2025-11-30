using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OwnerUserId { get; set; }

        public Users Owner { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
