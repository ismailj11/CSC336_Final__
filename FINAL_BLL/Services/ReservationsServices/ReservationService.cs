using AutoMapper;
using FINAL_BLL.DTOS.Pilots;
using FINAL_BLL.DTOS.Reservations;
using FINAL_BLL.Services.GenericServices;
using FINAL_BLL.Services.Pilots;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.Pilots;
using FINAL_DAL.Repositories.Reservations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.ReservationsServices
{
    public class ReservationService : GenericService<Reservation, ReservationDto>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }




    }
}
