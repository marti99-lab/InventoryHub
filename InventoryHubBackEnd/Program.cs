var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

//CORS
app.UseCors("AllowAll");

//API Endpoint
app.MapGet("/api/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop", Price = 1200.50, Stock = 25, Category = new { Id = 101, Name = "Electronics" } },
        new { Id = 2, Name = "Headphones", Price = 50.00, Stock = 100, Category = new { Id = 102, Name = "Accessories" } },
        new { Id = 3, Name = "Smartphone", Price = 899.99, Stock = 30, Category = new { Id = 101, Name = "Electronics" } },
        new { Id = 4, Name = "Mechanical Keyboard", Price = 150.00, Stock = 50, Category = new { Id = 103, Name = "Computer Accessories" } },
        new { Id = 5, Name = "Gaming Mouse", Price = 75.00, Stock = 60, Category = new { Id = 103, Name = "Computer Accessories" } },
        new { Id = 6, Name = "Monitor", Price = 299.99, Stock = 20, Category = new { Id = 104, Name = "Displays" } },
        new { Id = 7, Name = "External SSD", Price = 129.99, Stock = 35, Category = new { Id = 105, Name = "Storage" } },
        new { Id = 8, Name = "Wireless Earbuds", Price = 199.99, Stock = 45, Category = new { Id = 102, Name = "Accessories" } },
        new { Id = 9, Name = "Smartwatch", Price = 349.99, Stock = 40, Category = new { Id = 106, Name = "Wearables" } },
        new { Id = 10, Name = "USB-C Hub", Price = 39.99, Stock = 80, Category = new { Id = 107, Name = "Adapters" } }
    };
});


app.Run();
