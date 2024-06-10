using AutoMapper.Execution;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.Airplanes
{
    public class AirplaneRepository : GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {
        }

        public Airplane GetAirplaneById(int id)
        {
            var result = _dbSet.Where(x => x.AirplaneId == id).FirstOrDefault();
            return result;
        }
    }
}
