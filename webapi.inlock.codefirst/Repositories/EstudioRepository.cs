using Microsoft.EntityFrameworkCore;
using webapi.inlock.codefirst.Contexts;
using webapi.inlock.codefirst.Domains;
using webapi.inlock.codefirst.Interfaces;

namespace webapi.inlock.codefirst.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {

        private InLockContext c;
        public EstudioRepository()
        {
            c = new InLockContext();
        }
        public void Atualizar(Estudio estudioAtualizado)
        {
            Estudio estudioBuscado = BuscarId(estudioAtualizado.IdEstudio);
            if (estudioBuscado != null)
            {
                estudioBuscado.Nome = estudioAtualizado.Nome;
            }

            c.Estudio.Update(estudioBuscado!);
            c.SaveChanges();
        }

        public Estudio BuscarId(Guid Id)
        {
           return c.Estudio.FirstOrDefault(estudio => estudio.IdEstudio == Id)!;
        }

        public void Cadastrar(Estudio estudioCadastrado)
        {
           c.Add(estudioCadastrado);
            c.SaveChanges();
        }

        public void Deletar(Guid Id)
        {
            Estudio estudioBuscado = BuscarId(Id);
            if (estudioBuscado != null)
            {
                c.Remove(estudioBuscado);
                c.SaveChanges();
            }
        }

        public List<Estudio> ListarTodos()
        {
           return c.Estudio.ToList();
        }
    }
}
