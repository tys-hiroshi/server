using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Bit.Core.Utilities;
using Bit.Core.Models.Api;
using System.Linq;
using Bit.Core.Repositories;
using System.Threading.Tasks;

namespace Bit.Api.Controllers
{
    [Route("plans")]
    [Authorize("Web")]
    public class PlansController : Controller
    {
        private readonly ITaxRateRepository _taxRateRepository;
        public PlansController(ITaxRateRepository taxRateRepository)
        {
            _taxRateRepository = taxRateRepository;
        }

        [HttpGet("")]
        public ListResponseModel<PlanResponseModel> Get()
        {
            var data = StaticStore.Plans;
            var responses = data.Select(plan => new PlanResponseModel(plan));
            return new ListResponseModel<PlanResponseModel>(responses);
        }

        [HttpGet("sales-tax-rates")]
        public async Task<ListResponseModel<TaxRateResponseModel>> GetTaxRates()
        {
            var data = await _taxRateRepository.GetAllActiveAsync();
            var responses = data.Select(x => new TaxRateResponseModel(x));
            return new ListResponseModel<TaxRateResponseModel>(responses);
        }
    }
}
