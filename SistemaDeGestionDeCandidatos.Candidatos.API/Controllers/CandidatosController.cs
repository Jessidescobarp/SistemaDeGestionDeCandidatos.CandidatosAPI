using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeGestionDeCandidatos.Candidatos.API.Data;
using SistemaDeGestionDeCandidatos.Candidatos.API.DTOs;
using SistemaDeGestionDeCandidatos.Candidatos.API.Services;
using System.Security.Policy;

namespace SistemaDeGestionDeCandidatos.Candidatos.API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatosController : Controller
    {

        private readonly ICandidatosService _candidatosServices;
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatosController(ICandidatosService candidatosServices, ICandidatoRepository candidatoRepository)
        {
            _candidatosServices = candidatosServices;
            _candidatoRepository = candidatoRepository;
        }

        // GET: CandidatosController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidatoDto>>> GetAllCandidates()
        {
            var candidates = await _candidatosServices.GetAllCandidatesAsync();
            return Ok(candidates);
        }


    }
}
