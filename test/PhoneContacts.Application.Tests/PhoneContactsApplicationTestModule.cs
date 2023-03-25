using Volo.Abp.Modularity;

namespace PhoneContacts;

[DependsOn(
    typeof(PhoneContactsApplicationModule),
    typeof(PhoneContactsDomainTestModule)
    )]
public class PhoneContactsApplicationTestModule : AbpModule
{

}
