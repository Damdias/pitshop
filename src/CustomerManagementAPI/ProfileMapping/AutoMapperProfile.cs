using AutoMapper;
using CustomerManagementAPI.Models;
using CustomerManagementAPI.Dto;
namespace CustomerManagementAPI.ProfileMapping;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerRequest, Customer>();
    }
}