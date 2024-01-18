using Kesten.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kesten.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VarietyController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IVarietyRepository _varietyRepository;

        public VarietyController(
            IHttpContextAccessor httpContextAccessor,
            IVarietyRepository varietyRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _varietyRepository = varietyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _varietyRepository.AllVarietiesAsync());
        }
    }
}
