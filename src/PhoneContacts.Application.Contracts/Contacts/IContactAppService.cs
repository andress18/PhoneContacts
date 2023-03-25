using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PhoneContacts.Contacts
{
    public interface IContactAppService : ICrudAppService<ContactDto,
        Guid, ContactPagedAndSortedResultRequestDto, CreateUpdateContactDto>
    {
    }
}
