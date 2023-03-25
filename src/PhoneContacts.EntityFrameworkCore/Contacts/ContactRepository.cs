using Microsoft.EntityFrameworkCore;
using PhoneContacts.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace PhoneContacts.Contacts
{
    public class ContactRepository : EfCoreRepository<PhoneContactsDbContext, Contact, Guid>, IContactRepository
    {
        public ContactRepository(IDbContextProvider<PhoneContactsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<Contact>> GetListAsync(int skipCount, int maxResultCount, string sorting = "Name", ContactFilter? filter = null)
        {
            var dbSet = await GetDbSetAsync();
            var books = await dbSet
                .WhereIf(!filter.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(filter.Name))
                .OrderBy(x => x.Name)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
            return books;
        }

        public async Task<int> GetTotalCountAsync(ContactFilter filter)
        {
            var dbSet = await GetDbSetAsync();
            var books = await dbSet
                .WhereIf(!filter.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(filter.Name))
                .ToListAsync();
            return books.Count;
        }
    }
}
