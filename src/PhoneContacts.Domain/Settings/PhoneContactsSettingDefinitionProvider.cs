using Volo.Abp.Settings;

namespace PhoneContacts.Settings;

public class PhoneContactsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PhoneContactsSettings.MySetting1));
    }
}
