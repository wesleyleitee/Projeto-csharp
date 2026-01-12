using OCP.Solution.Estrategias;
namespace OCP.Solution
{
    internal class UsuarioService
    {        
        private readonly IEnumerable<INotificacaoPorTipoUsuario> _estrategias;

        public UsuarioService(IEnumerable<INotificacaoPorTipoUsuario> estrategias)
        {
            _estrategias = estrategias;
        }

        public void CriarUsuario(Usuario usuario)
        {
            var estrategia = _estrategias.First(e => e.Tipo == usuario.Tipo);

            foreach (var notificacao in estrategia.ObterNotificacoes())
            {
                notificacao.Enviar(usuario);
            }
        }
    }   
}
