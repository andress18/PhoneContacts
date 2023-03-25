using AutoMapper;
using PhoneContacts.Contacts;

namespace PhoneContacts.Blazor;

public class PhoneContactsBlazorAutoMapperProfile : Profile
{
    public PhoneContactsBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.
        CreateMap<ContactDto, CreateUpdateContactDto>().ReverseMap();
    }
}
