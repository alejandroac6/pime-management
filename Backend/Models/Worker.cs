using System.ComponentModel.DataAnnotations;
namespace Backend.Models;

public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }
    public string Password { get; set; }
    public Company AssignedCompany { get; set; }
    public List<Project> AssignedProjects { get; set; }
}