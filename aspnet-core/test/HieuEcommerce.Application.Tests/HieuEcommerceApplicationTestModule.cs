using Volo.Abp.Modularity;

namespace HieuEcommerce;

[DependsOn(
    typeof(HieuEcommerceApplicationModule),
    typeof(HieuEcommerceDomainTestModule)
    )]
public class HieuEcommerceApplicationTestModule : AbpModule
{

}
