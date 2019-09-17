using System;
using System.Collections.Generic;

namespace Travel_Management_System.Models
{
    public partial class TripDetails
    {
        public int TripId { get; set; }
        public string TripName { get; set; }
        public string PlaceFrom { get; set; }
        public string PlaceTo { get; set; }
        public string Duration { get; set; }
        public int? Fare { get; set; }
        public string Description { get; set; }
    }
}
