using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Todos
{
    [Dependency(ReplaceServices = true)]
    public class TodosBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Todos";
    }
}
