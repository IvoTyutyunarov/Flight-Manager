using System;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.Models
{
    public class FlightCreateViewModel
    {
        [Display(Name = "Destination City")]
        public string DestinationCity { get; set; }
        [Display(Name = "Departure City")]
        public string DepartureCity { get; set; }
        [Display(Name = "Departure Time")]
        public DateTime DepartureTime { get; set; }
        [Display(Name = "Arrival Time")]
        public DateTime ArrivalTime { get; set; }
        public string PlaneType { get; set; }
        public string PlaneID { get; set; }
        [Display(Name = "Captain Name")]
        public string CaptainName { get; set; }
        [Display(Name = "Plane Capacity")]
        public int PlaneCapacity { get; set; }
        [Display(Name = "Business Class Capacity")]
        public int BusinessClassCapacity { get; set; }
    }
}
