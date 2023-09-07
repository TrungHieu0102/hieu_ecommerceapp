using Volo.Abp.Modularity;

namespace HieuEcommerce.Public;

[DependsOn(
    typeof(HieuEcommercePublicApplicationModule),
    typeof(HieuEcommerceDomainTestModule)
    )]
public class HieuEcommercePublicApplicationTestModule : AbpModule
{

}
