using CartorioCivil.Contexto;
using CartorioCivil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CartorioCivil.Controles
{
    [Route("api/nascimento")]
    [ApiController]
    public class NascimentoController : ControllerBase
    {

        private DataBaseContext _contextNascimento;

        public NascimentoController(DataBaseContext context)
        {
            _contextNascimento = context;
        }

        [HttpGet]
        public ActionResult<List<Nascimento>> Get()
        {
            return Ok(_contextNascimento.Nascimentos.ToList());
        }

        // POST api/<Nascimento>
        [HttpPost]
        public ActionResult<Nascimento> Post([FromBody] Nascimento nascimento)
        {

            _contextNascimento.Nascimentos.Add(nascimento); 
            return Ok();
        }

    }
}
