using HieuEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HieuEcommerce.Public.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HieuEcommercePublicController : AbpControllerBase
{
    protected HieuEcommercePublicController()
    {
        LocalizationResource = typeof(HieuEcommerceResource);
    }
}
