using webapi.inlock.codefirst.Domains;

namespace webapi.inlock.codefirst.Interfaces
{
    public interface IEstudioRepository
    {
        void Cadastrar(Estudio estudioCadastrado);
        List<Estudio> ListarTodos();
        Estudio BuscarId(Guid Id);
        void Atualizar(Estudio estudioAtualizado);
        void Deletar(Guid Id);
    }
}
