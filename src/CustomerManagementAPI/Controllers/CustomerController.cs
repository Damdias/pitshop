using Microsoft.AspNetCore.Mvc;
using System.Net;
using AutoMapper;

using CustomerManagementAPI.DB;
using CustomerManagementAPI.Dto;
using CustomerManagementAPI.Models;

namespace CustomerManagementAPI.Controller;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{

    CustomerDbContext _dbContext;
    IMapper _mapper;
    public CustomerController(CustomerDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    [HttpGet(Name = "Get Customers")]
    [ProducesResponseType(typeof(CustomerResponse), (int)HttpStatusCode.OK)]
    public IActionResult Get()
    {
        return Ok(new CustomerResponse());
    }

    [HttpPost(Name = "Save Customer")]
    public async Task<IActionResult> Post([FromBody] CreateCustomerRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var customerEntity = _mapper.Map<Customer>(request);

        await _dbContext.Customers.AddAsync(customerEntity);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

}