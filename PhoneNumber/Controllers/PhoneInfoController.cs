using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneNumber.Domain.Interfaces.Services;

namespace PhoneNumber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneInfoController : ControllerBase
    {
        private readonly IPhoneInfoService phoneInfoService;

        public PhoneInfoController(IPhoneInfoService phoneInfoService)
        {
            this.phoneInfoService = phoneInfoService;
        }

        [HttpGet]
        public async Task <ActionResult> GetCountryInfo(string phoneNumber)
        {
            var result = phoneInfoService.GetCountryInfo(phoneNumber);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound("Country not found for the given phone number.");
        }
    }
}
