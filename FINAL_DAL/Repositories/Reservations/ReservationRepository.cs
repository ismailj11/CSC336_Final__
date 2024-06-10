using FINAL_DAL.Models;
using FINAL_DAL.Repositories.GenericRepository;
using FINAL_DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.Reservations
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {
        }


    }
}
