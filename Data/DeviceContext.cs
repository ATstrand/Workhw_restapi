using Microsoft.EntityFrameworkCore;
using _24._03workapp.Models;

namespace _24._03workapp.Data;

public class DeviceContext : DbContext
{
    public DeviceContext (DbContextOptions<DeviceContext> options)
        : base(options)
    {
    }

    public DbSet<Device> Devices => Set<Device>();
    public DbSet<Application> Applications => Set<Application>();
    public DbSet<Extra> Extras => Set<Extra>();
}