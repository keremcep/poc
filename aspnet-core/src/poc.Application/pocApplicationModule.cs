using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using poc.Authorization;

namespace poc
{
    [DependsOn(
        typeof(pocCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class pocApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<pocAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(pocApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
