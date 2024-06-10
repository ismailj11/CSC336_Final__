using FINAL_DAL.Models;
using FINAL_DAL.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.Passengers
{
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {
        }

        public Passenger GetPassengerByID(int id)
        {
            var result = _dbSet.Where(x => x.PassengerId == id).FirstOrDefault();
            return result;
        }
    }
}
