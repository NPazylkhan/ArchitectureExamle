namespace Models
{
    //модели - это то, что мы принимаем извне и отдаем наружу
    public class DriverModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<VehicleModel> Vehicles { get; set; }
    }
}
