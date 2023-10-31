namespace webapi.inlock.codefirst.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma HASH a partir de uma senha
        /// </summary>
        /// <param name="senha">Senha que receberá a HASH</param>
        /// <returns>Senha criptografada</returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// Verifica se a HASH da senha informada é igual a HASH salva no Banco de Dados
        /// </summary>
        /// <param name="senhaForm">Senha do usuário</param>
        /// <param name="senhaBanco">Senha do Banco de Dados</param>
        /// <returns>True or False</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
