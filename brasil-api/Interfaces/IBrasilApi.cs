using brasil_api.Dtos;
using brasil_api.Models;
using System.Globalization;

namespace brasil_api.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGeneric<AddressModel>> GetAddressByZipCode(string code);
        Task<ResponseGeneric<List<BankModel>>> GetAllBanks();
        Task<ResponseGeneric<BankModel>>GetBank(String bankCode);


    }
}
