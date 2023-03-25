using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PhoneContacts.Contacts
{
    public class ContactAppService : CrudAppService<Contact,
        ContactDto, Guid, ContactPagedAndSortedResultRequestDto, CreateUpdateContactDto>, IContactAppService
    {
        private readonly IContactRepository _contactRepository;

        public ContactAppService(IContactRepository repository) : base(repository)
        {
            _contactRepository = repository;
        }
        public override async Task<PagedResultDto<ContactDto>> GetListAsync(ContactPagedAndSortedResultRequestDto input)
        {
            var filter = ObjectMapper.Map<ContactPagedAndSortedResultRequestDto, ContactFilter>(input);

            var sorting = (string.IsNullOrEmpty(input.Sorting) ? "Name DESC" : input.Sorting).Replace("ShortName", "Name");

            var books = await _contactRepository.GetListAsync(input.SkipCount, input.MaxResultCount, sorting, filter);
            var totalCount = await _contactRepository.GetTotalCountAsync(filter);

            return new PagedResultDto<ContactDto>(totalCount, ObjectMapper.Map<List<Contact>, List<ContactDto>>(books));
        }
    }
}
