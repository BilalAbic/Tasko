using Core.Entities;
using DataAccess.Context;
namespace Tasko.DataAccess.Repositories
{
    public class InviteRepository : GenericRepository<OrganizationInvite>, IInviteRepository
    {
        public InviteRepository(TaskoDbContext context) : base(context)
        {
        }

        // Özel metodlar eklenebilir
    }
}
