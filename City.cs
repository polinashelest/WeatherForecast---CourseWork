namespace WeatherForecast
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public City(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
