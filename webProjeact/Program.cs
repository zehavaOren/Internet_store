using Microsoft.Extensions.Options;
using DataRepository;
using Entity;
using Microsoft.EntityFrameworkCore;
using Service;
using NLog.Web;
using Middlewares;
using webProjeact;

var builder = WebApplication.CreateBuilder(args);
var conectionString = builder.Configuration.GetConnectionString("school");
builder.Services.AddDbContext<web_dbContext>(option => option.UseSqlServer(conectionString));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Host.UseNLog();


// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddScoped< IUserRepository, UserRepository>();
builder.Services.AddScoped<IuserService, UsersService>();

builder.Services.AddScoped<IPasswordService, PasswordService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
builder.Services.AddScoped<IProductsService, ProductsService>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IRatingRepository, RatingRepository>();
builder.Services.AddScoped<IRatingService, RatingService>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseErrorHandlingMiddleware();

//app.UseCashingMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRaingMiddleware();

app.Run();

