using Microsoft.EntityFrameworkCore;
using Productos.API.Application;
using Productos.API.Application.Services;
using Productos.API.Infrastructure;
using Productos.API.Domain;

var builder = WebApplication.CreateBuilder(args);

// Conexión a SQL Server (ajusta tu connection string)
builder.Services.AddDbContext<ProductosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inyección de dependencias
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<ProductoService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
