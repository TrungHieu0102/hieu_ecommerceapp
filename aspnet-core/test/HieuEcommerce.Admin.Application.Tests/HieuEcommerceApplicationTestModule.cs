using Volo.Abp.Modularity;

namespace HieuEcommerce.Admin;

[DependsOn(
    typeof(HieuEcommerceAdminApplicationModule),
    typeof(HieuEcommerceDomainTestModule)
    )]
public class HieuEcommerceApplicationTestModule : AbpModule
{

}
