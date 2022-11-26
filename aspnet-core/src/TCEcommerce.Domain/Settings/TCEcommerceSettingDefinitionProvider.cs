using Volo.Abp.Settings;

namespace TCEcommerce.Settings;

public class TCEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TCEcommerceSettings.MySetting1));
    }
}
