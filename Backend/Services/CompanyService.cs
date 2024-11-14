using Backend.Models;
using Backend.Data;

namespace Backend.Services;

public class CompanyService
{

    private readonly PimeContext _context;

    public CompanyService(PimeContext context)
    {
        _context = context;
    }
}