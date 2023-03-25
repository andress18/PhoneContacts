using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace PhoneContacts.Contacts
{
    public interface IContactRepository : IRepository<Contact, Guid>
    {
        Task<List<Contact>> GetListAsync(int skipCount, int maxResultCount, string sorting= "Name", ContactFilter? filter = null);
        Task<int> GetTotalCountAsync(ContactFilter filter);
    }
}
