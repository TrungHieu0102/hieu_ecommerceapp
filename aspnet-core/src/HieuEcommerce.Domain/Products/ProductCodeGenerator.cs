﻿using HieuEcommerce.IdentitySettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HieuEcommerce.Products
{
    public class ProductCodeGenerator : ITransientDependency
    {
        private readonly IRepository<IdentitySetting, string> _identitySettingRepository;

        public ProductCodeGenerator(IRepository<IdentitySetting, string> identitySettingRepository)
        {
            _identitySettingRepository = identitySettingRepository;
        }
        public async Task<string> GenerateAsync()
        {
            string newCode;
            var identitySetting = await _identitySettingRepository.FindAsync(HieuEcommerceConsts.ProductIdentitySettingId);
            if (identitySetting == null)
            {
                identitySetting = await _identitySettingRepository.InsertAsync(new IdentitySetting(HieuEcommerceConsts.ProductIdentitySettingId, "Sản phẩm", HieuEcommerceConsts.ProductIdentitySettingPrefix, 1, 1));
                newCode = identitySetting.Prefix + identitySetting.CurrentNumber;

            }
            else
            {
                identitySetting.CurrentNumber += identitySetting.StepNumber;
                newCode = identitySetting.Prefix + identitySetting.CurrentNumber;

                await _identitySettingRepository.UpdateAsync(identitySetting);
            }
            return newCode;
        }
    }
}
