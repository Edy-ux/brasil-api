using brasil_api.Dtos;

namespace brasil_api.Interfaces
{
    public interface IBankService
    {
        Task<ResponseGeneric<List<BankDTO>>> GetAllBanks();
    }
}
