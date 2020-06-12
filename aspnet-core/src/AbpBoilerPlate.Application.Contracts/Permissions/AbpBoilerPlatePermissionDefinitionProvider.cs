using AbpBoilerPlate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpBoilerPlate.Permissions
{
    public class AbpBoilerPlatePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpBoilerPlatePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpBoilerPlatePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpBoilerPlateResource>(name);
        }
    }
}
