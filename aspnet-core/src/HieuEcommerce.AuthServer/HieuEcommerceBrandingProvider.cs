using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HieuEcommerce;

[Dependency(ReplaceServices = true)]
public class HieuEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HieuEcommerce";
}
