using TangBunao.Mall.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TangBunao.Mall.Permissions
{
    public class MallPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MallPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(MallPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MallResource>(name);
        }
    }
}
