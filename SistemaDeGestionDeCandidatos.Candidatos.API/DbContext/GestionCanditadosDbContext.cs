using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionDeCandidatos.Candidatos.API.Models;


namespace SistemaDeGestionDeCandidatos.Context
{
    public class GestionCanditadosDbContext:DbContext
    {
        public GestionCanditadosDbContext(DbContextOptions<GestionCanditadosDbContext> options) : base(options){}

        // Se definen DbSets que estan en la base de datos
        public DbSet<Candidates> Candidates { get; set; } = null!;      
    }

}
