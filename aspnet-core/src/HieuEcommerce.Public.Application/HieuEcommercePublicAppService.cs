using System;
using System.Collections.Generic;
using System.Text;
using HieuEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace HieuEcommerce.Public;

/* Inherit your application services from this class.
 */
public abstract class HieuEcommercePublicAppService : ApplicationService
{
    protected HieuEcommercePublicAppService()
    {
        LocalizationResource = typeof(HieuEcommerceResource);
    }
}
