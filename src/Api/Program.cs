using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using RToora.DemoWebApi.API.Data;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SampleDBContext>(options => options.UseSqlServer("name=DefaultConnection"));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;  // this line fixes circular references on eager loading
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// Endpoints
WeatherEndpoints.Map(app);
BlogEndpoints.Map(app);
GenerosEndpoints.Map(app);
ActoresEndpoints.Map(app);
PeliculasEndpoints.Map(app);
ComentariosEndpoints.Map(app);

app.Run();
