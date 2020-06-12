using Volo.Abp.Settings;

namespace AbpBoilerPlate.Settings
{
    public class AbpBoilerPlateSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpBoilerPlateSettings.MySetting1));
        }
    }
}
