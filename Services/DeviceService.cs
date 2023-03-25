using _24._03workapp.Models;
using _24._03workapp.Data;
using Microsoft.EntityFrameworkCore;

namespace _24._03workapp.Services;

public class DeviceService
{
    private readonly DeviceContext _context;

    public DeviceService(DeviceContext context)
    {
        _context = context;
    }

    public IEnumerable<Device> GetAll()
    {
        return _context.Devices
            .AsNoTracking()
            .ToList();
    }

    public Device? GetById(int id)
    {
        return _context.Devices
            .Include(d => d.Extras)
            .Include(d => d.Application)
            .AsNoTracking()
            .SingleOrDefault(d => d.Id == id);
    }

    public Device? Create(Device newDevice)
    {
        _context.Devices.Add(newDevice);
        _context.SaveChanges();
        return newDevice;
    }

    public void AddExtra(int DeviceId, int ExtraId)
    {
       var DeviceToUpdate = _context.Devices.Find(DeviceId);
        var ExtraToAdd = _context.Extras.Find(ExtraId);

        if (DeviceToUpdate is null || ExtraToAdd is null)
        {
            throw new InvalidOperationException("Device or extra attachment does not exist");
        }

        if(DeviceToUpdate.Extras is null)
        {
            DeviceToUpdate.Extras = new List<Extra>();
        }

        DeviceToUpdate.Extras.Add(ExtraToAdd);

        _context.SaveChanges();
    }

    public void UpdateApplication(int DeviceId, int ApplicationId)
    {
        var DeviceToUpdate = _context.Devices.Find(DeviceId);
        var ApplicationToUpdate = _context.Applications.Find(ApplicationId);

        if (DeviceToUpdate is null || ApplicationToUpdate is null)
        {
            throw new InvalidOperationException("Device or application does not exist");
        }

        DeviceToUpdate.Application = ApplicationToUpdate;

        _context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var DeviceToDelete = _context.Devices.Find(id);
        if (DeviceToDelete is not null)
        {
            _context.Devices.Remove(DeviceToDelete);
            _context.SaveChanges();
        }        
    }
}