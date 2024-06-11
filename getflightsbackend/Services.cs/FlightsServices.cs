using System;
using System.Text.Json;
using getflightsbackend.Models;
using getflightsbackend.RepositoryModels;

namespace getflightsbackend.Repository
{
	public class FlightsServices: IFlightsServices
    {
		private IFlightsRepository _flights;

		public FlightsServices(IFlightsRepository flights)
		{
            _flights = flights;
		}

        public Task<Flight> Create(Flight flight)
        {
            throw new NotImplementedException();
        }

        public Task<Flight> DeleteFlight(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Flight> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Flight>? GetFlights()
        {
            return _flights.GetFlights();
        }

        public Task<Flight> Update(string id, Flight flight)
        {
            throw new NotImplementedException();
        }
    }
}

