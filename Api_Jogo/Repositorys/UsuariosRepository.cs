using Api_Jogo.Contexts;
using Api_Jogo.Domains;
using Api_Jogo.Interfaces;

namespace Api_Jogo.Repositorys
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly Context _context;

        public UsuariosRepository(Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Usuarios usuario)
        {
            
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.NomeUsuario = usuario.NomeUsuario;
                }

                _context.Usuarios.Update(usuario!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                return _context.Usuarios.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuarios usuarios)
        {
            try
            {
                usuarios.IdUsuario = Guid.NewGuid();
                _context.Usuarios.Add(usuarios);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Jogos jogo = _context.Jogos.Find(id)!;
                if (jogo != null)
                {
                    _context.Jogos.Remove(jogo);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuarios> Listar()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
