using SistemaDeGestionDeCandidatos.Candidatos.API.Models;

namespace SistemaDeGestionDeCandidatos.Candidatos.API.Data
{
    public interface ICandidatoRepository
    {
        Task<IEnumerable<Candidates>> GetAllAsync();  
    }
}
