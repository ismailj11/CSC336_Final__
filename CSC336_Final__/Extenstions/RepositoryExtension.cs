using FINAL_DAL.Repositories.Airplanes;
using FINAL_DAL.Repositories.Flights;
using FINAL_DAL.Repositories.Passengers;
using FINAL_DAL.Repositories.Pilots;
using FINAL_DAL.Repositories.Reservations;

namespace CSC336_Final__.Extenstions
{
    public static class repositoryExtension
    {

        public static IServiceCollection AddRepositories(this IServiceCollection Services)
        {
            Services.AddScoped<IPassengerRepository, PassengerRepository>();
            Services.AddScoped<IPilotRepository, PilotRepository>();
            Services.AddScoped<IFlightRepository, FlightRepository>();
            Services.AddScoped<IAirplaneRepository, AirplaneRepository>();
            Services.AddScoped<IReservationRepository, ReservationRepository>();
         

            return Services;
        }



    }
}
