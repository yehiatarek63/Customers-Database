using Customers.API.Models;
using Customers.Data.DatabaseSpecific;
using Customers.Data.EntityClasses;
using Customers.Data.Linq;
using Microsoft.AspNetCore.Mvc;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using Npgsql;
using View.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Postgres");
RuntimeConfiguration.AddConnectionString("Postgres", builder.Configuration.GetConnectionString("Postgres"));
RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(c =>
{
    c.AddDbProviderFactory(typeof(NpgsqlFactory));
});
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapPost("/add-customer", async([FromBody] Customer customer) =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        try
        {
            CustomerEntity customerEntity = new()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                Email = customer.Email,
                ZipCode = customer.ZipCode
            };
            await adapter.SaveEntityAsync(customerEntity, true);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
});
app.MapPost("/add-order", async([FromBody] Order order) =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        try
        {
            OrderEntity orderEntity = new()
            {
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                OrderName = order.OrderName,
                Status = order.Status,
                Total = order.Total
            };
            await adapter.SaveEntityAsync(orderEntity, true);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
});
app.MapGet("/get-order-view", async () =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        try
        {
            var metaData = new LinqMetaData(adapter);
            var orderView = await metaData.Order.ProjectToOrderView().ToListAsync();
            return Results.Ok(orderView);
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
});

app.Run();

