using Volo.Abp.Application.Services;
using ABPBoilerplateTeste.Localization;

namespace ABPBoilerplateTeste.Services;

/* Inherit your application services from this class. */
public abstract class ABPBoilerplateTesteAppService : ApplicationService
{
    protected ABPBoilerplateTesteAppService()
    {
        LocalizationResource = typeof(ABPBoilerplateTesteResource);
    }
}