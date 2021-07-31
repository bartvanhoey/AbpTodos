using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Todos.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class TodosBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Todos";
    }
}
