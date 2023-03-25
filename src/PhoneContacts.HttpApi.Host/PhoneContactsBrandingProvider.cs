using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PhoneContacts;

[Dependency(ReplaceServices = true)]
public class PhoneContactsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PhoneContacts";
}
