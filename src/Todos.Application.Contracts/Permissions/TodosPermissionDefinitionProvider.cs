using Todos.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Todos.Permissions
{
    public class TodosPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var todosGroup = context.AddGroup(TodosPermissions.TodosGroup, L("Permission:TodosGroup"));

            var todosPermission = todosGroup.AddPermission(TodosPermissions.Todos.Default, L("Permission:Todos"));
            todosPermission.AddChild(TodosPermissions.Todos.Create, L("Permission:Todos:Create"));
            todosPermission.AddChild(TodosPermissions.Todos.Update, L("Permission:Todos:Update"));
            todosPermission.AddChild(TodosPermissions.Todos.Delete, L("Permission:Todos:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TodosResource>(name);
        }
    }
}
