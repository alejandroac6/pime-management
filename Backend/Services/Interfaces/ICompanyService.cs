using Backend.DTOs;

namespace Backend.Services.Interfaces;

public interface ICompanyService{
    Task<bool> RegisterAsync(CompanyRegisterDto companyRegisterDto);
}