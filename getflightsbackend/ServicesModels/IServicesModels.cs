using System;
using getflightsbackend.Models;

namespace getflightsbackend.RepositoryModels
{
	public interface IFlightsServices
	{
		public List<Flight>? GetFlights();
        public Task<Flight> GetById(string id);
		public Task<Flight> Create(Flight flight);
		public Task<Flight> DeleteFlight(string id);
		public Task<Flight> Update(string id, Flight flight);
	}
}

