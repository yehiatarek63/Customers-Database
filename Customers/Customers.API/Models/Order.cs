using System.Text.Json.Serialization;

namespace Customers.API.Models;

public class Order
{
    public int Id { get; set; }
    [JsonPropertyName("customer_id")]
    public int CustomerId { get; set; }
    [JsonPropertyName("order_name")]
    public string OrderName { get; set; }
    public decimal Total { get; set; }
    [JsonPropertyName("order_date")]
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
}
