using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tasko.DataAccess.Repositories;

namespace Tasko.Business.Services
{
    public class InviteService : IInviteService
    {
        private readonly IInviteRepository _inviteRepository;

        public InviteService(IInviteRepository inviteRepository)
        {
            _inviteRepository = inviteRepository;
        }

        public async Task<List<OrganizationInvite>> GetAllInvitesAsync()
        {
            return await _inviteRepository.GetAllAsync();
        }

        public async Task<OrganizationInvite> GetInviteByIdAsync(int id)
        {
            return await _inviteRepository.GetByIdAsync(id);
        }

        public async Task AddInviteAsync(OrganizationInvite invite)
        {
            invite.Uses = 0;
            invite.IsActive = true;
            await _inviteRepository.AddAsync(invite);
        }

        public async Task UpdateInviteAsync(OrganizationInvite invite)
        {
            _inviteRepository.Update(invite);
        }

        public async Task DeleteInviteAsync(int id)
        {
            var invite = await _inviteRepository.GetByIdAsync(id);
            if (invite != null)
                _inviteRepository.Delete(invite);
        }
    }
}
