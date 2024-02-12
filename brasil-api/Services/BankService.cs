using AutoMapper;
using brasil_api.Dtos;
using brasil_api.Interfaces;

namespace brasil_api.Services
{
    public class BankService : IBankService
    {

        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public BankService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGeneric<List<BankDTO>>> GetAllBanks()
        {
            var response = await _brasilApi.GetAllBanks();
            return _mapper.Map<ResponseGeneric<List<BankDTO>>>(response);  
        }
    }
}
