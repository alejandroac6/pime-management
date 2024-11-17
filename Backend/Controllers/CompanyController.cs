using Microsoft.AspNetCore.Mvc;
using Backend.Services.Interfaces;
using Backend.Models;
using Backend.Services;
using Backend.DTOs;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CompanyController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService){
        _companyService = companyService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register (CompanyRegisterDto companyRegisterDto){
        var result = await _companyService.RegisterAsync(companyRegisterDto);

        //TODO THROW ERROR IF S NOT OK

        if (!result){
            return BadRequest("Te user exists or the invalid data introduced");
        }

        return Ok("Company successfully registered");
    }

}