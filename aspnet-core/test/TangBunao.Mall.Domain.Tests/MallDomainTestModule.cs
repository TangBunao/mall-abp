using TangBunao.Mall.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TangBunao.Mall
{
    [DependsOn(
        typeof(MallEntityFrameworkCoreTestModule)
        )]
    public class MallDomainTestModule : AbpModule
    {

    }
}