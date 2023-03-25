using PhoneContacts.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PhoneContacts.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PhoneContactsController : AbpControllerBase
{
    protected PhoneContactsController()
    {
        LocalizationResource = typeof(PhoneContactsResource);
    }
}
