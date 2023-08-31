using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HieuEcommerce.Data;

/* This is used if database provider does't define
 * IHieuEcommerceDbSchemaMigrator implementation.
 */
public class NullHieuEcommerceDbSchemaMigrator : IHieuEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
