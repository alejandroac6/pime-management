using Backend.Models;
using Backend.Data;

namespace Backend.Services;

public class WorkerService{

    private readonly PimeContext _context;

    public WorkerService(PimeContext context){
        _context=context;
    }

}