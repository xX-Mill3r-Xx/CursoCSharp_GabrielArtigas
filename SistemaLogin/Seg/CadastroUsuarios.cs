using SistemaLogin.Entities;

namespace SistemaLogin.Seg
{
    public static class CadastroUsuarios
    {
        private static Usuario[] _usuarios =
        {
            new Usuario(){ Nome = "miller", Senha = "abc123"},
            new Usuario(){ Nome = "admin", Senha = "admin" }
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado 
        { 
            get { return _usuarioLogado; } 
            private set { _usuarioLogado = value; }
        }

        public static bool ValidarUsuario(string nome, string senha)
        {
            foreach (var usuario in _usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}
