using Data.Repositories.Abstract;
using Entities;

namespace Data.Repositories
{
    //CRUD Repository
    //repository должен быть в ед. экземпляре и потокобезопасным
    //Active Record, ORM(Object-Relational Mapping)
    public class DriversRepository : IDriversRepository
    {
        private static List<DriverEntity> _list = new List<DriverEntity>();

        public void AddDriver(DriverEntity driver)
        {
            throw new NotImplementedException();
        }

        public void DeleteDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public DriverEntity GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(DriverEntity driver)
        {
            throw new NotImplementedException();
        }
    }
}
