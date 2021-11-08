using System;
using System.Collections.Generic;
using System.Text;
using TangBunao.Mall.Localization;
using Volo.Abp.Application.Services;

namespace TangBunao.Mall
{
    /* Inherit your application services from this class.
     */
    public abstract class MallAppService : ApplicationService
    {
        protected MallAppService()
        {
            LocalizationResource = typeof(MallResource);
        }
    }
}
