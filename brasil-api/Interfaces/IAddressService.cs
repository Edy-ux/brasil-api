using brasil_api.Dtos;
using brasil_api.Models;

namespace brasil_api.Interfaces
{
    public interface IAddressService
    {
        Task<ResponseGeneric<AddressDTO>> GetAddressByZipCode(string code);
    }
}
