namespace NewsweatherAPI.Dtos.Weather
{
    public class AddWeatherDto
    {
        public string Weather_Time { get; set; }
        public string Temperature { get; set; }
        public string Weather_Description { get; set; }
        public string Wind_Speed { get; set; }
        public string Wind_Degree { get; set; }
        public string Wind_Direction { get; set; }
        public string Presure { get; set; }
        public int CityId {get; set;}
    }
}