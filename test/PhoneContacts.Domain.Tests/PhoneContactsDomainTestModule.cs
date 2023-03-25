using PhoneContacts.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PhoneContacts;

[DependsOn(
    typeof(PhoneContactsEntityFrameworkCoreTestModule)
    )]
public class PhoneContactsDomainTestModule : AbpModule
{

}
