using PhoneContacts.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PhoneContacts.Blazor;

public abstract class PhoneContactsComponentBase : AbpComponentBase
{
    protected PhoneContactsComponentBase()
    {
        LocalizationResource = typeof(PhoneContactsResource);
    }
}
