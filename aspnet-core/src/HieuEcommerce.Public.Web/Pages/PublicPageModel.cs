using HieuEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HieuEcommerce.Public.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PublicPageModel : AbpPageModel
{
    protected PublicPageModel()
    {
        LocalizationResourceType = typeof(HieuEcommerceResource);
    }
}
