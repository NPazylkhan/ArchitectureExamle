using Domain;
using Entities;
using Models;

namespace Mappers
{
    public static class DriverMapper
    {
        public static DriverEntity ToEntity(this Driver driver)
        {
            return new DriverEntity
            {
                Age = driver.Age,
                Name = driver.Name
            };
        }

        public static Driver ToDomain(this DriverModel driver)
        {
            if(driver == null) return null;

            return new Driver
            {
                Name = driver.Name,
                Age = driver.Age

                Vehicles = driver.Vehicles.Select(x=>x.ToDomain()).ToList()
            };
        }
    }
}
