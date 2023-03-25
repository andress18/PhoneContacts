using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PhoneContacts.Data;

/* This is used if database provider does't define
 * IPhoneContactsDbSchemaMigrator implementation.
 */
public class NullPhoneContactsDbSchemaMigrator : IPhoneContactsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
