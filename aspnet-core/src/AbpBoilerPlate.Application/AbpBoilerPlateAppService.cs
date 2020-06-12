using System;
using System.Collections.Generic;
using System.Text;
using AbpBoilerPlate.Localization;
using Volo.Abp.Application.Services;

namespace AbpBoilerPlate
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpBoilerPlateAppService : ApplicationService
    {
        protected AbpBoilerPlateAppService()
        {
            LocalizationResource = typeof(AbpBoilerPlateResource);
        }
    }
}
