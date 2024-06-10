using FINAL_DAL.Models;
using FINAL_DAL.Repositories.GenericRepository;
using FINAL_DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.Flights
{
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        public FlightRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {
        }


    }
}
