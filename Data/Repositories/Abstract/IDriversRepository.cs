using Entities;

namespace Data.Repositories.Abstract
{
    public interface IDriversRepository
    {
        void AddDriver(DriverEntity driver);
        void UpdateDriver(DriverEntity driver);
        DriverEntity GetDriverById(int id);
        void DeleteDriverById(int id);
    }
}
