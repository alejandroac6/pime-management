using System.ComponentModel.DataAnnotations;
namespace Backend.Models;

public class Project{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Cost{ get; set; }
    public decimal Hours{ get; set; }
    public Company AssignedCompany{ get; set; }
    public List<Worker> AssignedWorkers{ get; set; }


}