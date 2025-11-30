using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

using Tasko.DataAccess.Repositories;

namespace Tasko.Business.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationService(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<List<Organization>> GetAllOrganizationsAsync()
        {
            return await _organizationRepository.GetAllAsync();
        }

        public async Task<Organization> GetOrganizationByIdAsync(int id)
        {
            return await _organizationRepository.GetByIdAsync(id);
        }

        public async Task AddOrganizationAsync(Organization org)
        {
            await _organizationRepository.AddAsync(org);
        }

        public async Task UpdateOrganizationAsync(Organization org)
        {
            _organizationRepository.Update(org);
        }

        public async Task DeleteOrganizationAsync(int id)
        {
            var org = await _organizationRepository.GetByIdAsync(id);
            if (org != null)
                _organizationRepository.Delete(org);
        }
    }
}
