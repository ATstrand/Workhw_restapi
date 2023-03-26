using _24._03workapp.Models;
using _24._03workapp.Services;
using Microsoft.AspNetCore.Mvc;

namespace _24._03workapp.Controllers;
// controller for GET, PUT, POST calls => look in service and context for db calls
[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
    DeviceService _service;
    
    public DeviceController(DeviceService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Device> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Device> GetById(int id)
    {
        var pizza = _service.GetById(id);

        if(pizza is not null)
        {
            return pizza;
        }
        else
        {
            return NotFound();
        }
    }


    [HttpPost]
    public IActionResult Create(Device newDevice)
    {
        var pizza = _service.Create(newDevice);
        return CreatedAtAction(nameof(GetById), new { id = pizza!.Id }, pizza);
    }

    [HttpPut("{id}/addExtra")]
    public IActionResult AddExtra(int id, int ExtraId)
    {
        var pizzaToUpdate = _service.GetById(id);

        if(pizzaToUpdate is not null)
        {
            _service.AddExtra(id, ExtraId);
            return NoContent();    
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPut("{id}/updateApplication")]
    public IActionResult UpdateApplication(int id, int ApplicationId)
    {
        var DeviceToUpdate = _service.GetById(id);

        if(DeviceToUpdate is not null)
        {
            _service.UpdateApplication(id, ApplicationId);
            return NoContent();    
        }
        else
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var device = _service.GetById(id);

        if(device is not null)
        {
            _service.DeleteById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}