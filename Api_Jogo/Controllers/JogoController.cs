using Api_Jogo.Domains;
using Api_Jogo.Interfaces;
using Api_Jogo.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Api_Jogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogoController : ControllerBase
    {
       private IJogosRepository _jogosRepository;

        public JogoController(IJogosRepository jogosRepository)
        {
            _jogosRepository = jogosRepository;
        }

        [HttpPost]
        public IActionResult Post(Jogos jogo)
        {
            try
            {
                _jogosRepository.Cadastrar(jogo);
                return Created();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("BuscarPorId/{Id}")]
        public IActionResult Get(Guid Id)
        {
            try
            {
                Jogos novoJogo = _jogosRepository.BuscarPorId(Id);
                return Ok(novoJogo);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _jogosRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Jogos> listaJogos = _jogosRepository.Listar();
                return Ok(listaJogos);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Jogos jogo)
        {
            try
            {
                   _jogosRepository .Atualizar(id, jogo);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


    }
}
