using Data.Repository.DataBase;
using Data.Repository.ProductRepo;
using Data.Repository.Repository.CategoryRepo;
using Data.Repository.Repository.OrderRepo;
using Data.Repository.Repository.ProductRepo;
using Data.Repository.Repository.SubCategoryRepo;
using Data.Repository.Repository.UserRepo;
using WebApplication1.Extensions;
using WebApplication1.Logger;
using ILogger = WebApplication1.Logger.ILogger;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.DBContextExtension<InventoryDbContext>(builder.Configuration);
builder.Services.AddControllers();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();
builder.Services.AddSingleton<ILogger, Logger>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseRouting();

app.MapControllers();

app.Run();
