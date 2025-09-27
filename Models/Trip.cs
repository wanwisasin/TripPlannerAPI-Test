
namespace TripPlannerAPI.Models;
public class Trip
{
   
    public int trip_id { get; set; }
    public string trip_name { get; set; } = null!;
    public string destination { get; set; } = null!;
    public DateTime start_date { get; set; }
    public DateTime end_date  { get; set; }
    public bool active { get; set; }
    public DateTime created_at { get; set; }
}

