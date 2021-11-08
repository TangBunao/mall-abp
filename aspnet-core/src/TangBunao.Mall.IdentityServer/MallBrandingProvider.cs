using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TangBunao.Mall
{
    [Dependency(ReplaceServices = true)]
    public class MallBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Mall";
    }
}
