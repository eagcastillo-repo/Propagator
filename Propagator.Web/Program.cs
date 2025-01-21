using Microsoft.EntityFrameworkCore;
using Propagator.Application.Abstractions;
using Propagator.Application.Queries;
using Propagator.Application.Repositories;
using Propagator.Infrastucture.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository, EmployeeRepository>();

builder.Services.AddDbContext<SQLiteContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Demo")));

builder.Services.AddGraphQLServer()
    .AddQueryType<EmployeeQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGraphQL();

app.Run();

