namespace TripPlannerAPI.Models;

    public class User
    {
        public int user_id { get; set; }
        public string uername { get; set; } = null!;
        public string email { get; set; } = null!;
        public bool active { get; set; }
        public DateTime created_at { get; set; }
    }