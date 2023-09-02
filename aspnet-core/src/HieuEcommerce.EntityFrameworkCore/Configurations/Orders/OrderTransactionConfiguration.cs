using HieuEcommerce.Orders;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuEcommerce.Orders
{
    public class OrderTransactionConfiguration : IEntityTypeConfiguration<OrderTransaction>
    {
        public void Configure(EntityTypeBuilder<OrderTransaction> builder)
        {
            builder.ToTable(HieuEcommerceConsts.DbTablePrefix + "OrderTransactions");

            builder.Property(x => x.Code)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .IsRequired();
        }
    }
}
