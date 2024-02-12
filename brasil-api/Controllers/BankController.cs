using brasil_api.Interfaces;
using brasil_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace brasil_api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBankService _banckService;

        public BankController(IBankService bankService)
        {
            _banckService = bankService;
        }

        [HttpGet("bancos/")]
        public async Task<ActionResult> GetAllBanks()
        {
           var response = await _banckService.GetAllBanks();

            if (response.StatusCodeHttp == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
