using Bit.Core.Models.Table;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bit.Core.Repositories
{
    public interface ITaxRateRepository : IRepository<TaxRate, string>
    {
        Task<ICollection<TaxRate>> SearchAsync(int skip, int count);
        Task<ICollection<TaxRate>> GetAllActiveAsync();
        Task ArchiveAsync(TaxRate model);
        Task<ICollection<TaxRate>> GetByLocationAsync(TaxRate taxRate);
    }
}
