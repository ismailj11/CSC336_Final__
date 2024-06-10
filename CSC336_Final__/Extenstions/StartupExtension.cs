using FINAL_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CSC336_Final__.Extenstions
{
    public static class StartUpExtension
    {

        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {

            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<AirplaneSystemContext>(options =>
                            options.UseSqlServer(ConnectionString)

                            );


            return service;




        }


    }
}
