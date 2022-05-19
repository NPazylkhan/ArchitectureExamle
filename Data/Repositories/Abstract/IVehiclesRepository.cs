using Entities;

namespace Data.Repositories.Abstract
{
    public interface IVehiclesRepository
    {
        void AddVehicle(VehicleEntity vehicle);
        void UpdateVehicle(VehicleEntity vehicle);
        List<VehicleEntity> GetAllVehicles();
        void DeleteVehicle(int id);
    }
}
