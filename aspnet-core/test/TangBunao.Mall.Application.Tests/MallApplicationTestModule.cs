using Volo.Abp.Modularity;

namespace TangBunao.Mall
{
    [DependsOn(
        typeof(MallApplicationModule),
        typeof(MallDomainTestModule)
        )]
    public class MallApplicationTestModule : AbpModule
    {

    }
}