using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api_Jogo.Domains;
using Api_Jogo.Interfaces;

namespace Api_Jogo.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuariosRepository _usuarioRepository;

        public UsuarioController(IUsuariosRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult Post(Usuarios novoUsuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);
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
                Usuarios novoUsuario = _usuarioRepository.BuscarPorId(Id);
                return Ok(novoUsuario);
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
                _usuarioRepository.Deletar(id);
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
                List<Usuarios> ListaUsuario = _usuarioRepository.Listar();
                return Ok(ListaUsuario);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(id, usuario);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


    }
}
