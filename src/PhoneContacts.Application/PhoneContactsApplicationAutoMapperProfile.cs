using AutoMapper;
using PhoneContacts.Contacts;

namespace PhoneContacts;

public class PhoneContactsApplicationAutoMapperProfile : Profile
{
    public PhoneContactsApplicationAutoMapperProfile()
    {
        CreateMap<Contact, ContactDto>();
        CreateMap<CreateUpdateContactDto, Contact>();
        CreateMap<ContactDto, CreateUpdateContactDto>().ReverseMap();
        CreateMap<ContactPagedAndSortedResultRequestDto, ContactFilter>();
    }
}
