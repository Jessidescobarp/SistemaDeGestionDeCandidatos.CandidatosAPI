using SistemaDeGestionDeCandidatos.Candidatos.API.DTOs;
namespace SistemaDeGestionDeCandidatos.Candidatos.API.Services
{
    public interface ICandidatosService
    {
        Task<IEnumerable<CandidatoDto>> GetAllCandidatesAsync();
    }
}
