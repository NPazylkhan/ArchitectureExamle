using Domain;

namespace Services.Abstract
{
    public interface IDriverService
    {
        void AddDriver(Driver driver);
        void UpdateDriver(Driver driver);
        Driver GetDriverById(int id);
        void DeleteDriverById(int id);
    }
}
