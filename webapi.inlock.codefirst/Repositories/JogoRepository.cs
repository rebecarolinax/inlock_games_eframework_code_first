using webapi.inlock.codefirst.Contexts;
using webapi.inlock.codefirst.Domains;
using webapi.inlock.codefirst.Interfaces;

namespace webapi.inlock.codefirst.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private InLockContext c;
        public JogoRepository()
        {
            c = new InLockContext();
        }

        public void Atualizar(Jogo jogoAtualizado)
        {
            Jogo jogoBuscado = BuscarId(jogoAtualizado.IdJogo);
            if (true)
            {

            }
        }

        public Jogo BuscarId(Guid Id)
        {
            return c.Jogo.FirstOrDefault(jogo => jogo.IdJogo == Id)!;
        }

        public void Cadastrar(Jogo jogoCadastrado)
        {
            c.Add(jogoCadastrado);
            c.SaveChanges();
        }

        public void Deletar(Guid Id)
        {
            Jogo jogoBuscado = BuscarId(Id);

            if (jogoBuscado != null)
            {
                c.Remove(jogoBuscado);
                c.SaveChanges();
            }

        }

        public List<Jogo> ListarTodos()
        {
            return c.Jogo.ToList();
        }
    }
}
