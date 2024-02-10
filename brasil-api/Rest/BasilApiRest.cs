using brasil_api.Dtos;
using brasil_api.Interfaces;
using brasil_api.Models;

namespace brasil_api.Rest
{
    public class BasilApiRest : IBrasilApi
    {
        public Task<ResponseGeneric<AddressModel>> GetAddressByZipCode(string code)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGeneric<List<BankModel>>> GetAllBanks()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGeneric<BankModel>> GetBank(string bankCode)
        {
            throw new NotImplementedException();
        }
    }
}
