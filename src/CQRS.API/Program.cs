using CQRS.Domain.Abstractions.Repository;
using CQRS.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using CQRS.API;
using MediatR;
using CQRS.Application.UserCases.V1.Commands.Product;
using CQRS.Application.UserCases.V1.Queries.Product;
using CQRS.Persistence;
using CQRS.Persistence.Repositories;
using CQRS.Domain.Entities;
using CQRS.Persistence.Etension.AutoMapper;
using CQRS.Application.Extension.AutoMapper;
using CQRS.Persistence.Extension.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});


// Register the AppDbContext with SQL Server or SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SeverConnectionTest")));

// Register Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IRepository<ProxyEntity>, ProxyRepository>();
builder.Services.AddScoped<IRepository<BrowserEntity>, BrowserRepository>();
builder.Services.AddScoped<IRepository<AccountEntity>, AccountsRepository>();


// Automapper CQRS.Persistence
builder.Services.AddAutoMapper(typeof(AccountsEntityProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AccountsInBrowserEntityProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AccountsInProjectProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AccountTypeProfile).Assembly);
builder.Services.AddAutoMapper(typeof(BrowserEntityProfile).Assembly);
builder.Services.AddAutoMapper(typeof(LogsProfile).Assembly);
builder.Services.AddAutoMapper(typeof(LogsProfile).Assembly);
builder.Services.AddAutoMapper(typeof(ProxyEntityProfile).Assembly);


// Automapper CQRS.Application
builder.Services.AddAutoMapper(typeof(ProxyCommandProfile).Assembly);
builder.Services.AddAutoMapper(typeof(BrowserCommandProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AccountCommandProfile).Assembly);

//// Register Command Handlers
builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<UpdateProductCommandHandler>();
builder.Services.AddScoped<DeleteProductCommandHandler>();

// Register Query Handlers
builder.Services.AddScoped<GetAllProductsQueryHandler>();
builder.Services.AddScoped<GetProductByIdQueryHandler>();


builder.Services.AddMediatR(typeof(CreateProductCommand).Assembly);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
