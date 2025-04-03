using Api_Jogo.Domains;

namespace Api_Jogo.Interfaces
{
    public interface IUsuariosRepository 
    {

        void Cadastrar(Usuarios usuario);
        void Deletar(Guid id);
        List<Usuarios> Listar();
        void Atualizar(Guid id, Usuarios usuario);
        Usuarios BuscarPorId(Guid id);

    }
}
