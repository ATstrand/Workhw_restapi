using System.ComponentModel.DataAnnotations;
namespace _24._03workapp.Models;

public class Application
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

}