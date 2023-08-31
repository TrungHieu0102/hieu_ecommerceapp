using System.Threading.Tasks;

namespace HieuEcommerce.Data;

public interface IHieuEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
