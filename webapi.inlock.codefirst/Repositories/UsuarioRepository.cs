using webapi.inlock.codefirst.Contexts;
using webapi.inlock.codefirst.Domains;
using webapi.inlock.codefirst.Interfaces;
using webapi.inlock.codefirst.Utils;

namespace webapi.inlock.codefirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly InLockContext c;
        public UsuarioRepository() 
        {
          c = new InLockContext();
        }
        public void Cadastrar(Usuario usuarioCadastrado)
        {
            try
            {
                usuarioCadastrado.Senha = Criptografia.GerarHash(usuarioCadastrado.Senha!);
                c.Add(usuarioCadastrado);
                c.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Usuario Logar(string Email, string Senha)
        {
            try
            {
                Usuario? usuarioBuscado = c.Usuario.FirstOrDefault(u => u.Email == Email);

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha!);

                    if (confere == true)
                    {
                        return usuarioBuscado;
                    }
                }

                return null;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
