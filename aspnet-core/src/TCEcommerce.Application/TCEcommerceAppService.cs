using System;
using System.Collections.Generic;
using System.Text;
using TCEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace TCEcommerce;

/* Inherit your application services from this class.
 */
public abstract class TCEcommerceAppService : ApplicationService
{
    protected TCEcommerceAppService()
    {
        LocalizationResource = typeof(TCEcommerceResource);
    }
}
