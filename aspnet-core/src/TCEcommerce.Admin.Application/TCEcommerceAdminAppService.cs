using System;
using System.Collections.Generic;
using System.Text;
using TCEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace TCEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class TCEcommerceAdminAppService : ApplicationService
{
    protected TCEcommerceAdminAppService()
    {
        LocalizationResource = typeof(TCEcommerceResource);
    }
}
