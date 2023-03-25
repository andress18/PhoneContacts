using System;
using System.Collections.Generic;
using System.Text;
using PhoneContacts.Localization;
using Volo.Abp.Application.Services;

namespace PhoneContacts;

/* Inherit your application services from this class.
 */
public abstract class PhoneContactsAppService : ApplicationService
{
    protected PhoneContactsAppService()
    {
        LocalizationResource = typeof(PhoneContactsResource);
    }
}
