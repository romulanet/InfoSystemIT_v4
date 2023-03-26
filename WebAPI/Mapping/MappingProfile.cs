using AutoMapper;
using Business.DataTransferObjects;
using Domain.Entities;

namespace webapi.Mapping
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
