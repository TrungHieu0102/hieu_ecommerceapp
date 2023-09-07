using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HieuEcommerce.Public.Web;

[Dependency(ReplaceServices = true)]
public class HieuEcommercePublicBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Public";
}
