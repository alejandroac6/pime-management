using System.ComponentModel.DataAnnotations;
namespace Backend.Models;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    [MaxLength(100)]
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Project> Projects { get; set; }
    public List<Worker> Workers { get; set; }
}
