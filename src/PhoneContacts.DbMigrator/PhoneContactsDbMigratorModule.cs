using PhoneContacts.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PhoneContacts.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PhoneContactsEntityFrameworkCoreModule),
    typeof(PhoneContactsApplicationContractsModule)
    )]
public class PhoneContactsDbMigratorModule : AbpModule
{

}
