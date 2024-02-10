using brasil_api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace brasil_api.Controllers
{   

    
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService  _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet("busca/{code}")]

        public async Task<ActionResult> GetAddress([FromRoute] string code)
        {
            var response = await _addressService.GetAddressByZipCode(code);

            if(response.StatusCodeHttp == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
               return StatusCode((int)response.StatusCodeHttp, response.ErrorReturn);
            }
        }
    }

}
