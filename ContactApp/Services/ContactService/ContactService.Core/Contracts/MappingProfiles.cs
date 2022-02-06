using AutoMapper;
using ContactService.Core.Dto;
using ContactService.Core.Model;

namespace ContactService.Core.Contracts;

public class ContactPersonProfile : Profile
{
    public ContactPersonProfile()
    {
        CreateMap<ContactPerson, ContactPersonDto>().ReverseMap();
    }
}

public class ContactInfoProfile : Profile
{
    public ContactInfoProfile()
    {
        CreateMap<ContactInfo, ContactInfoDto>().ReverseMap();
    }
}
