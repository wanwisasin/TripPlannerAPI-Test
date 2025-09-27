namespace TripPlannerAPI.Models;
    public class UserTrip
    {
        public int user_trip_id { get; set; }
        public int user_id { get; set; }
        public int trip_id { get; set; }
        public string role { get; set; } = "member";
        public DateTime joined_at { get; set; }
        public bool active { get; set; }
    }