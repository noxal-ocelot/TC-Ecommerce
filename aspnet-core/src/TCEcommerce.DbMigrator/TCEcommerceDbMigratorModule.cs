using TCEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TCEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TCEcommerceEntityFrameworkCoreModule),
    typeof(TCEcommerceApplicationContractsModule)
    )]
public class TCEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
