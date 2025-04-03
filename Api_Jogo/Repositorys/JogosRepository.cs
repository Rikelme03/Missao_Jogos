using Api_Jogo.Contexts;
using Api_Jogo.Domains;
using Api_Jogo.Interfaces;

namespace Api_Jogo.Repositorys
{
    public class JogosRepository : IJogosRepository
    {
        private readonly Context _context;
        public JogosRepository(Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Jogos jogos)
        {
            try
            {
                Jogos jogoBuscado = _context.Jogos.Find(id)!;
                if (jogoBuscado != null)
                {
                    jogoBuscado.NomeJogo = jogos.NomeJogo;

                }
                _context.Jogos.Update(jogoBuscado!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Jogos? BuscarPorId(Guid id)
        {
            try
            {
                return _context.Jogos.Find(id); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Jogos jogos)
        {
            try
            {
                jogos.JogosId = Guid.NewGuid();
                _context.Jogos.Add(jogos);
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

        public List<Jogos> Listar()
        {
            try
            {
                return _context.Jogos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
