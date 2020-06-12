using AbpBoilerPlate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpBoilerPlate.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpBoilerPlateController : AbpController
    {
        protected AbpBoilerPlateController()
        {
            LocalizationResource = typeof(AbpBoilerPlateResource);
        }
    }
}