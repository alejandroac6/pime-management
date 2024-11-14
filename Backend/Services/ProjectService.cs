using Backend.Models;
using Backend.Data;
using Backend.DTOs;
using Backend.Services.Interfaces;
namespace Backend.Services;

public class ProjectService
{


    private readonly PimeContext _context;

    public ProjectService(PimeContext context)
    {
        _context = context;
    }

}