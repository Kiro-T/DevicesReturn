using Microsoft.EntityFrameworkCore;
using SmartDevicesReturn.Model;

namespace SmartDevicesReturn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<DeviceCategory> DeviceCategory { get; set; }
    }
}
