using System;
using System.Text.Json.Serialization;
namespace getflightsbackend.Models
{
	public class Flight
	{
		[JsonPropertyName("id")]
		public string? Id { set; get; }
		[JsonPropertyName("company")]
		public string? Company { set; get; }
		[JsonPropertyName("point")]
		public int Point { set; get; }
		[JsonPropertyName("duration")]
		public int Duration { set; get; }
		[JsonPropertyName("segment")]
		public List<Segment>? Segment { get; set; }

    }
	public class Segment
	{
		[JsonPropertyName("duration")]
		public int Duration { set; get; }
		[JsonPropertyName("departureTime")]	
		public string? DepartureTime { set; get; }
		[JsonPropertyName("arrivalTime")]
		public string? ArrivalTime { set; get; }
		[JsonPropertyName("origin")]
		public string? Origin { set; get; }
		[JsonPropertyName("destination")]
		public string? Destination { set; get; }
    }
}

