using HieuEcommerce.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuEcommerce.Products
{
    public class ProductAttributeTextConfiguration : IEntityTypeConfiguration<ProductAttributeText>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeText> builder)
        {
            builder.ToTable(HieuEcommerceConsts.DbTablePrefix + "ProductAttributeTexts");
            builder.HasKey(x => x.Id);
        }
    }
}
