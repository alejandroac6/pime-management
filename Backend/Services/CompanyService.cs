using Backend.Models;
using Backend.Data;
using Backend.DTOs;
using Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services;

public class CompanyService: ICompanyService
{

    private readonly PimeContext _context;

    public CompanyService(PimeContext context)
    {
        _context = context;
    }

    public async Task<bool> RegisterAsync(CompanyRegisterDto companyRegisterDto){
        bool companyExists= await _context.Companies.AnyAsync(c => c.Email == companyRegisterDto.Email || c.Name == companyRegisterDto.Name);

        if (companyExists){
            // LANZAR UN ERROR EN CASO DE QUE YA EXISTA EL TEMA
            return false;
        }

        var hashedPassword= BCrypt.Net.BCrypt.HashPassword(companyRegisterDto.Password);

        var company = new Company{
            Email = companyRegisterDto.Email,
            Password=hashedPassword,
            Name = companyRegisterDto.Name,
        };

        _context.Companies.Add(company);

        await _context.SaveChangesAsync();

        //LANZAR UN JSON INDICANDO EL ID TAMBIEN QUIERO ENVIAR UN ESTADO DE SUCCESS
        return true;


    }
}