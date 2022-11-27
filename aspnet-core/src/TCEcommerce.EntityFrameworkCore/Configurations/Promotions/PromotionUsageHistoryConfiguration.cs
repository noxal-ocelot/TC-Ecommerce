using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TCEcommerce.Promotions
{
    public class PromotionUsageHistoryConfiguration : IEntityTypeConfiguration<PromotionUsageHistory>
    {
        public void Configure(EntityTypeBuilder<PromotionUsageHistory> builder)
        {
            builder.ToTable(TCEcommerceConsts.DbTablePrefix + "PromotionUsageHistories");
            builder.HasKey(x => x.Id);
        }
    }
}