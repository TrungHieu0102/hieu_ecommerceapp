using HieuEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HieuEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HieuEcommerceController : AbpControllerBase
{
    protected HieuEcommerceController()
    {
        LocalizationResource = typeof(HieuEcommerceResource);
    }
}
