using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Services.FlightsServices;
using FINAL_BLL.Services.PassengersServices;
using FINAL_BLL.Services.Pilots;
using FINAL_BLL.Services.ReservationsServices;

namespace CSC336_Final__.Extenstions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceExtension(this IServiceCollection services)
        {
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IPassengerService, PassengerService>();
            services.AddScoped<IAirplaneService, AirplaneService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IPilotService, PilotService>();
          


            return services;
        }
    }
}
