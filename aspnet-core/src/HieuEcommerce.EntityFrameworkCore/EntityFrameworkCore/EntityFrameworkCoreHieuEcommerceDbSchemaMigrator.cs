using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HieuEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace HieuEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreHieuEcommerceDbSchemaMigrator
    : IHieuEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHieuEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HieuEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HieuEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
