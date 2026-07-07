using RepositoryPattern.Domain;

namespace RepositoryPattern.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private static readonly List<Usuario> _usuarios = new();

        public void Salvar(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
    }
}
