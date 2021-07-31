using Todos.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Todos.Blazor
{
    public abstract class TodosComponentBase : AbpComponentBase
    {
        protected TodosComponentBase()
        {
            LocalizationResource = typeof(TodosResource);
        }
    }
}
