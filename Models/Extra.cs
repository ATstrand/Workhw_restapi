using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace _24._03workapp.Models;
// Model for keeping track on attachments, like microphone,speaker
public class Extra
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    [JsonIgnore]
    public ICollection<Device>? Devices { get; set; }
    
}