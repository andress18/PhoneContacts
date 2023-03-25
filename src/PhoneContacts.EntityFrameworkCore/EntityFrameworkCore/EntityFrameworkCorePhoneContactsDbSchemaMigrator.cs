using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoneContacts.Data;
using Volo.Abp.DependencyInjection;

namespace PhoneContacts.EntityFrameworkCore;

public class EntityFrameworkCorePhoneContactsDbSchemaMigrator
    : IPhoneContactsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePhoneContactsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PhoneContactsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PhoneContactsDbContext>()
            .Database
            .MigrateAsync();
    }
}
