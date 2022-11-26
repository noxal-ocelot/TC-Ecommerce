using TCEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TCEcommerce;

[DependsOn(
    typeof(TCEcommerceEntityFrameworkCoreTestModule)
    )]
public class TCEcommerceDomainTestModule : AbpModule
{

}
