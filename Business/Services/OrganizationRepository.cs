using Core.Entities;
using DataAccess.Context;

namespace Tasko.DataAccess.Repositories
{
    public class OrganizationRepository : GenericRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(TaskoDbContext context) : base(context)
        {
        }

        // Ek metodlar eklenebilir
    }
}
