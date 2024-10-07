using Microsoft.EntityFrameworkCore;
using SistemaDeGestionDeCandidatos.Candidatos.API.Models;
using SistemaDeGestionDeCandidatos.Context;

namespace SistemaDeGestionDeCandidatos.Candidatos.API.Data
{
    public class CandidatoRepository: ICandidatoRepository
    {
        private readonly GestionCanditadosDbContext _context;
        public CandidatoRepository(GestionCanditadosDbContext context)
        {
            _context = context;
        }           
        public async Task<IEnumerable<Candidates>> GetAllAsync()
        {
            return await _context.Candidates.ToListAsync();
        }
    }
}
