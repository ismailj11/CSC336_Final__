using AutoMapper;
using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.DTOS.Pilots;
using FINAL_BLL.DTOS.Reservations;
using FINAL_BLL.DTOS.Reservationwithflightandpassenger;
using FINAL_BLL.Services.GenericServices;
using FINAL_BLL.Services.Pilots;
using FINAL_BLL.Wrapping.Exceptions;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.Flights;
using FINAL_DAL.Repositories.Passengers;
using FINAL_DAL.Repositories.Pilots;
using FINAL_DAL.Repositories.Reservations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FINAL_BLL.Services.ReservationsServices
{
    public class ReservationService : GenericService<Reservation, ReservationDto>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IPassengerRepository _passengerRepository;
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper , IPassengerRepository passengerRepository, IFlightRepository flightRepository) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
            _passengerRepository = passengerRepository;
            _flightRepository = flightRepository;


        }

        public ApiResponse<ReservationWithFlightAndPassengerDto> AddResWithFlightPass(ReservationWithFlightAndPassengerDto dto)
        {
            var response = new ApiResponse<ReservationWithFlightAndPassengerDto>();

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    



                    // Add the category
                    
                    
                    
                    
                    var reservation = new Reservation { ReservationId = dto.ReservationId };
                    _reservationRepository.Add(reservation);

                    // Get the generated CategoryId
                    

                    // Map the products and set the foreign key
                    var passangers = _mapper.Map<Passenger>(dto.Passenger);


                    var flights = _mapper.Map<Flight>(dto.Flight);

                    // Mark the transaction as complete
                    scope.Complete();

                    // New ids
                    var createdReservationDto = _mapper.Map<ReservationWithFlightAndPassengerDto>(reservation);
                    createdReservationDto.Flight = _mapper.Map<FlightDto>(flights);
                    createdReservationDto.Passenger = _mapper.Map<PassengerDto>(passangers);

                    response.Data = createdReservationDto;
                    response.Success = true;
                }
                catch (Exception ex)
                {
                    // Any exceptions will automatically trigger a rollback when scope.Complete() is not called
                    response.Success = false;
                    response.ErrorMessage = "An error occurred while adding the category and products";
                    response.Errors.Add(ex.Message);
                }
            }

            return response;
        
    }
    }
}
