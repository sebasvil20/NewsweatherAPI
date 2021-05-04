namespace NewsweatherAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public string City_Name { get; set; }
        public string City_Population { get; set; }
        public Weather Weather { get; set; }
    }
}