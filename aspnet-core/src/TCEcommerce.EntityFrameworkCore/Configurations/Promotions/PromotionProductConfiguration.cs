﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TCEcommerce.Promotions
{
    public class PromotionProductConfiguration : IEntityTypeConfiguration<PromotionProduct>
    {
        public void Configure(EntityTypeBuilder<PromotionProduct> builder)
        {
            builder.ToTable(TCEcommerceConsts.DbTablePrefix + "PromotionProducts");
            builder.HasKey(x => x.Id);
        }
    }
}