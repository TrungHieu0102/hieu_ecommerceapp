using HieuEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HieuEcommerce;

[DependsOn(
    typeof(HieuEcommerceEntityFrameworkCoreTestModule)
    )]
public class HieuEcommerceDomainTestModule : AbpModule
{

}
