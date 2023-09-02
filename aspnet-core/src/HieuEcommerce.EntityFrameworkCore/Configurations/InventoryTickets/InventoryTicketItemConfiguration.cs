using HieuEcommerce.InventoryTickets;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuEcommerce.InventoryTickets
{
    public class InventoryTicketItemConfiguration : IEntityTypeConfiguration<InventoryTicketItem>
    {
        public void Configure(EntityTypeBuilder<InventoryTicketItem> builder)
        {
            builder.ToTable(HieuEcommerceConsts.DbTablePrefix + "InventoryTicketItems");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SKU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.BatchNumber)
               .HasMaxLength(50)
               .IsUnicode(false);
        }
    }
}
