using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.Driver;

namespace WebApplication2.Models.User
{
    public interface IDriverRepository
    {
        DriverModel GetDriver(Guid Id);
        DbSet<DriverModel> GetDriverList();
        void Save();
    }
}