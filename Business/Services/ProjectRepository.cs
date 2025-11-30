using Core.Entities;
using DataAccess.Context;

namespace Tasko.DataAccess.Repositories
{
    public class ProjectRepository : GenericRepository<Projects>, IProjectRepository
    {
        public ProjectRepository(TaskoDbContext context) : base(context)
        {
        }

        // Project’e özel metodlar buraya eklenebilir
    }
}
