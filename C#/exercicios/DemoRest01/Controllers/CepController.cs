using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoRest01.Models;
using DemoRest01.Services;

namespace DemoRest01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private readonly ILogger<CepController> _logger;
        private readonly ICepService _cepService;

        public CepController(ILogger<CepController> logger, ICepService cepService)
        {
            _logger = logger;
            _cepService = cepService;
        }

        //GET /cep/90210010
        [HttpGet("{cep:regex(^\\d{{8}}$)}")]
        public ActionResult<ConsultaCep> ConsultaCep(string cep)
        {
            _logger.LogInformation($"ConsultaCep: {cep}");
            var resultado = _cepService.ConsultaPorCep(cep);
            if (resultado == null)
            {
                return NotFound();
            }
            return resultado;
        }

        //GET /cep
        [HttpGet]
        public IEnumerable<ConsultaCep> ConsultaCeps()
        {
            _logger.LogInformation("ConsultaCeps");
            return _cepService.ConsultaTodos()
                .OrderBy(c => c.Estado)
                .ThenBy(c => c.Cidade);
        }

        //GET /cep/deuruim
        [HttpGet("deuruim")]
        public void Deuruim()
        {
            _cepService.FazAlgoRuim();
        }
    }
}