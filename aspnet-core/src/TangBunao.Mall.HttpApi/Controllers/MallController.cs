using TangBunao.Mall.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TangBunao.Mall.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MallController : AbpController
    {
        protected MallController()
        {
            LocalizationResource = typeof(MallResource);
        }
    }
}