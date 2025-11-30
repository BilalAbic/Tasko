using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasko.Business.Services
{
    public interface IInviteService
    {
        Task<List<OrganizationInvite>> GetAllInvitesAsync();
        Task<OrganizationInvite> GetInviteByIdAsync(int id);
        Task AddInviteAsync(OrganizationInvite invite);
        Task UpdateInviteAsync(OrganizationInvite invite);
        Task DeleteInviteAsync(int id);
    }
}
