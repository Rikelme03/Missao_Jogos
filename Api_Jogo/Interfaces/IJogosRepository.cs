using Api_Jogo.Domains;

namespace Api_Jogo.Interfaces
{
    public interface IJogosRepository
    {
        void Cadastrar(Jogos jogos);

        Jogos BuscarPorId(Guid id);
        List <Jogos> Listar();

        void Deletar(Guid id);

        void Atualizar(Guid id, Jogos jogos);
    }
}
