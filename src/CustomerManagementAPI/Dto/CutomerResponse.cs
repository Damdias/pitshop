namespace CustomerManagementAPI.Dto;

public class CustomerResponse
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string TelephoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
}