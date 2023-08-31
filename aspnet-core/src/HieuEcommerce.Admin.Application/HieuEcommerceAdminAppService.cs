using System;
using System.Collections.Generic;
using System.Text;
using HieuEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace HieuEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class HieuEcommerceAdminAppService : ApplicationService
{
    protected HieuEcommerceAdminAppService()
    {
        LocalizationResource = typeof(HieuEcommerceResource);
    }
}
