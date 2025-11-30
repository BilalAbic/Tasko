using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasko.Business.Services
{
    public interface IOrganizationService
    {
        Task<List<Organization>> GetAllOrganizationsAsync();
        Task<Organization> GetOrganizationByIdAsync(int id);
        Task AddOrganizationAsync(Organization org);
        Task UpdateOrganizationAsync(Organization org);
        Task DeleteOrganizationAsync(int id);
    }
}
