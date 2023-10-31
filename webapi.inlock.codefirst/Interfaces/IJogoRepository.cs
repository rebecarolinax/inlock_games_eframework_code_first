using webapi.inlock.codefirst.Domains;

namespace webapi.inlock.codefirst.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogoCadastrado);
        List<Jogo> ListarTodos();
        Jogo BuscarId(Guid id);
        void Atualizar(Jogo jogoAtualizado);
        void Deletar(Guid Id);
    }
}
