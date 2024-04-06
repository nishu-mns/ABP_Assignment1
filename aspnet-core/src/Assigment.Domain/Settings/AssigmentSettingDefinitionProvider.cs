using Volo.Abp.Settings;

namespace Assigment.Settings;

public class AssigmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AssigmentSettings.MySetting1));
    }
}
