using SistemaDeGestionDeCandidatos.Candidatos.API.Data;
using SistemaDeGestionDeCandidatos.Candidatos.API.DTOs;

namespace SistemaDeGestionDeCandidatos.Candidatos.API.Services
{
    public class CandidatosService: ICandidatosService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatosService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public async Task<IEnumerable<CandidatoDto>> GetAllCandidatesAsync()
        {
            var candidates = await _candidatoRepository.GetAllAsync();
            return candidates.Select(c => new CandidatoDto { IdCandidate = c.IdCandidate});
        }
    }
}
