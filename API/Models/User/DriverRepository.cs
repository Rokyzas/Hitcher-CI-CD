using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models.Driver;

namespace WebApplication2.Models.User
{

    public class DriverRepository : IDriverRepository
    {
        private DbSet<DriverModel> _driverList;
        public DataContext _context;

        public DriverRepository(DataContext context)
        {
            _context = context;
            _driverList = context.Drivers;
        }

        public DriverModel GetDriver(Guid Id)
        {
            return _driverList.FirstOrDefault(e => e.UserID == Id);
        }

        public DbSet<DriverModel> GetDriverList()
        {
            return _driverList;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }

}
