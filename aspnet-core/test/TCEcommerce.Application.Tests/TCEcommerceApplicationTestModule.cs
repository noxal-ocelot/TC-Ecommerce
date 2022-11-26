using Volo.Abp.Modularity;

namespace TCEcommerce;

[DependsOn(
    typeof(TCEcommerceApplicationModule),
    typeof(TCEcommerceDomainTestModule)
    )]
public class TCEcommerceApplicationTestModule : AbpModule
{

}
