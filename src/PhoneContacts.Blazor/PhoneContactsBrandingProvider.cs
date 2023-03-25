using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PhoneContacts.Blazor;

[Dependency(ReplaceServices = true)]
public class PhoneContactsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PhoneContacts";
}
