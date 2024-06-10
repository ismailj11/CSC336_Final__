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
    public interface IAirplaneRepository : IGenericRepository<Airplane>
    {
        Airplane GetAirplaneById(int id);
    }
}
