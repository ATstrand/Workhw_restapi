using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace _24._03workapp.Models;

public class Extra
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    [JsonIgnore]
    public ICollection<Device>? Devices { get; set; }
    
}