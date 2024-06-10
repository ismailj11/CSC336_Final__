using CSC336_Final__.Filters;

namespace CSC336_Final__.Extenstions
{
    public static class AddControllers
    {

        public static IServiceCollection AddController(this IServiceCollection Services)
        {
            Services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return Services;
        }
    }
}
