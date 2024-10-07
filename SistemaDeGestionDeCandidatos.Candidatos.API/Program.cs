using Microsoft.EntityFrameworkCore;
using SistemaDeGestionDeCandidatos.Candidatos.API.Data;
using SistemaDeGestionDeCandidatos.Candidatos.API.Services;
using SistemaDeGestionDeCandidatos.Context;

var builder = WebApplication.CreateBuilder(args);

//// Configuración para SQL In-Memory
//builder.Services.AddDbContext<GestionCanditadosDbContext>(options =>
//    options.UseInMemoryDatabase("GestionCanditadosDb"));

// Configuración para SQL Express (LocalDB)
builder.Services.AddDbContext<GestionCanditadosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICandidatosService, CandidatosService>();
builder.Services.AddScoped<ICandidatoRepository, CandidatoRepository>();

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
