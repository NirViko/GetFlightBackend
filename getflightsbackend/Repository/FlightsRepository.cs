using System;
using System.Text.Json;
using getflightsbackend.Models;
using getflightsbackend.RepositoryModels;

namespace getflightsbackend.Repository
{
	public class FlightsRepository: IFlightsRepository
    {
		private List<Flight> flights;
		public FlightsRepository()
		{
            flights = JsonSerializer.Deserialize<List<Flight>>(File.ReadAllText("./Data/flights.json"))?? new List<Flight>();
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
			try {
				return flights;

			} catch(Exception e) {
				
				Console.WriteLine(e.Message);
				return null;

			}
        }

        public Task<Flight> Update(string id, Flight flight)
        {
            throw new NotImplementedException();
        }
    }
}

