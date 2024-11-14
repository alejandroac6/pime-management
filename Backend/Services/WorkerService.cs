using Backend.Models;
using Backend.Data;
using Backend.DTOs;
using Backend.Services.Interfaces;

namespace Backend.Services;

public class WorkerService{

    private readonly PimeContext _context;

    public WorkerService(PimeContext context){
        _context=context;
    }

}