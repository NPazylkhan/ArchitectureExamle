using Data.Repositories.Abstract;
using Domain;
using Mappers;
using Services.Abstract;

namespace Services
{
    public class DriverService : IDriversService
    {
        private readonly IDriversRepository _driversRepository;

        public DriverService(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public void AddDriver(Driver driver)
        {
            _driversRepository.AddDriver(driver.ToEntity());
        }

        public void DeleteDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public Driver GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
