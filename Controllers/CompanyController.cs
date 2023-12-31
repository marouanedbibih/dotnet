using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Company;
using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext context;
        private IMapper mapper;

        public CompanyController(ApplicationDbContext context ,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            Company company = mapper.Map<Company>(dto);
            await context.companies.AddAsync(company);
            await context.SaveChangesAsync();

            return Ok("Company created successfully");

        }
        [HttpGet]
        [Route("get")]

        public async Task<ActionResult<IEnumerable<CompanyGetDto>>> getCompanies()
        {
            var companies = await context.companies.ToListAsync();
            var convertedCompanies = mapper.Map<IEnumerable<CompanyGetDto>>(companies);

            return Ok(convertedCompanies);
        }


    }
}
