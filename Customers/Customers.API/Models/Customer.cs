using System.Text.Json.Serialization;

namespace Customers.API.Models;

public class Customer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }
    [JsonPropertyName("last_name")]
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    [JsonPropertyName("zip_code")]
    public string ZipCode { get; set; }

}
