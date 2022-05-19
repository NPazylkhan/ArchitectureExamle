namespace Domain
{
    //доменные объекты нужны непосредственно для бизнес-логики, происходящей в сервисах.
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
