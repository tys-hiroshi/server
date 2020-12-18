using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Table;

namespace Bit.Core.Repositories
{
    public interface ISsoConfigRepository : IRepository<SsoConfig, long>
    {
        Task<SsoConfig> GetByOrganizationIdAsync(Guid organizationId);
        Task<SsoConfig> GetByIdentifierAsync(string identifier);
        Task<ICollection<SsoConfig>> GetManyByRevisionNotBeforeDate(DateTime? notBefore);
    }
}
