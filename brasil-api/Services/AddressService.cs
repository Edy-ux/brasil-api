using AutoMapper;
using brasil_api.Dtos;
using brasil_api.Interfaces;
using brasil_api.Models;

namespace brasil_api.Services
{
    public class AddressService : IAddressService
    {

        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public AddressService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<AddressDTO>> GetAddressByZipCode(string code)
        {
           
           var address = await _brasilApi.GetAddressByZipCode(code);
           return _mapper.Map<ResponseGeneric<AddressDTO>>(address);
        
        }
    }
}
