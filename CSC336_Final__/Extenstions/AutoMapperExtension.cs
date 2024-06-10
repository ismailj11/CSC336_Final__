using FINAL_BLL.Mapping;

namespace CSC336_Final__.Extenstions
{
    public static class AutoMapperExtension
    {

        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;

        }


    }
}
