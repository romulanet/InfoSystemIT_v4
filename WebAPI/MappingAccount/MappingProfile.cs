using AutoMapper;
using Business.AuthDTO;
using Domain.Entities;

namespace WebAPI.MappingAccount
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.FirstName));
        }
    }
}
