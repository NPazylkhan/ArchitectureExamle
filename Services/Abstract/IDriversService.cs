using Domain;

namespace Services.Abstract
{
    public interface IDriversService
    {
        void AddDriver(Driver driver);
        void UpdateDriver(Driver driver);
        Driver GetDriverById(int id);
        void DeleteDriverById(int id);
    }
}
