using AutoMapper;
using brasil_api.Dtos;
using brasil_api.Models;

namespace brasil_api.Mappings
{
    public class BankMappin : Profile
    {
        public BankMappin()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<BankDTO, BankModel>();
            CreateMap<BankModel, BankDTO>();
        }
    }
}
