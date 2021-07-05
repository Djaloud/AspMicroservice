using MicroserviceEtudiant.Model;
using MicroserviceEtudiant.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace MicroserviceEtudiant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EtudiantController : ControllerBase
    {
       
        IEtudiantRepository _etudiantRepository;
        private readonly ILogger<EtudiantController> _logger;
        public EtudiantController(ILogger<EtudiantController> logger,IEtudiantRepository ietudiantRepository)
        {
            _etudiantRepository = ietudiantRepository;
            _logger = logger;
        }

        // GET: EtudiantController
       [HttpGet]
        public IActionResult Get()
        {
            var etudiant = _etudiantRepository.GetEtudiants();
            return new OkObjectResult(etudiant);
            //return Ok(etudiant);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Etudiant etudiant)
        {
            using (var scope = new TransactionScope())
            {
                _etudiantRepository.InsertEtudiant(etudiant);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = etudiant.id_etudiant }, etudiant);
            }
        }



        [HttpPut]
        public IActionResult Put([FromBody] Etudiant etudiant)
        {
            if (etudiant != null)
            {
                using (var scope = new TransactionScope())
                {
                    _etudiantRepository.UpdateEtudiant(etudiant);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }



        [HttpDelete("{id_etudiant}")]
        public IActionResult Delete(int id_etudiant)
        {
            _etudiantRepository.DeleteEtudiant(id_etudiant);
            return new OkResult();
        }
        
       
    }
}
