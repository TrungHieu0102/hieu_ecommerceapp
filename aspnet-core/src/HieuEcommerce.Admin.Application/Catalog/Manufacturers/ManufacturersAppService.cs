using HieuEcommerce.Admin.Permissions;
using HieuEcommerce.Manufacturers;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HieuEcommerce.Admin.Catalog.Manufacturers
{
    [Authorize(HieuEcommercePermissions.Manufacturer.Default,Policy ="AdminOnly")]
    public class ManufacturersAppService : CrudAppService<
       Manufacturer,
       ManufacturerDto,
       Guid,
       PagedResultRequestDto,
       CreateUpdateManufacturerDto,
       CreateUpdateManufacturerDto>, IManufacturersAppService
    {

        public ManufacturersAppService(IRepository<Manufacturer, Guid> repository)
            : base(repository)
        {

            GetPolicyName = HieuEcommercePermissions.Manufacturer.Default;
            GetListPolicyName = HieuEcommercePermissions.Manufacturer.Default;
            CreatePolicyName = HieuEcommercePermissions.Manufacturer.Create;
            UpdatePolicyName = HieuEcommercePermissions.Manufacturer.Update;
            DeletePolicyName = HieuEcommercePermissions.Manufacturer.Delete;
        }
        [Authorize(HieuEcommercePermissions.Manufacturer.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }

        [Authorize(HieuEcommercePermissions.Manufacturer.Default)]
        public async Task<List<ManufacturerInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<Manufacturer>, List<ManufacturerInListDto>>(data);

        }

        [Authorize(HieuEcommercePermissions.Manufacturer.Default)]


        public async Task<PagedResultDto<ManufacturerInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ManufacturerInListDto>(totalCount, ObjectMapper.Map<List<Manufacturer>, List<ManufacturerInListDto>>(data));
        }


    }
}
