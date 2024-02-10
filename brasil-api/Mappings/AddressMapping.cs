using AutoMapper;
using brasil_api.Dtos;
using brasil_api.Models;

namespace brasil_api.Mappings
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<AddressDTO, AddressModel>();
            CreateMap<AddressModel, AddressDTO>();
        }
    }
}
