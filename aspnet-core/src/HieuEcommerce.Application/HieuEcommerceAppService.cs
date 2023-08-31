using System;
using System.Collections.Generic;
using System.Text;
using HieuEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace HieuEcommerce;

/* Inherit your application services from this class.
 */
public abstract class HieuEcommerceAppService : ApplicationService
{
    protected HieuEcommerceAppService()
    {
        LocalizationResource = typeof(HieuEcommerceResource);
    }
}
