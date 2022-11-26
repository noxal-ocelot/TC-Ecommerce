using Volo.Abp.Modularity;

namespace TCEcommerce.Admin;

[DependsOn(
    typeof(TCEcommerceAdminApplicationModule),
    typeof(TCEcommerceDomainTestModule)
    )]
public class TCEcommerceApplicationTestModule : AbpModule
{

}
