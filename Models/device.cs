using System.ComponentModel.DataAnnotations;
namespace _24._03workapp.Models;
// Model for devices
public class Device
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public Application? Application{ get ; set; }

    public ICollection<Extra>? Extras {get; set;}
    
}