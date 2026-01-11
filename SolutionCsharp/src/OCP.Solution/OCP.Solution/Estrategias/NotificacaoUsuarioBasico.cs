using OCP.Solution.Notificacoes;

namespace OCP.Solution.Estrategias
{
    internal class NotificacaoUsuarioBasico : INotificacaoPorTipoUsuario
    {
        public TipoUsuarioEnum Tipo => TipoUsuarioEnum.Basico;

        public IEnumerable<INotificacaoService> ObterNotificacoes()
        {
            return new INotificacaoService[]
            {
                new EmailService()
            };
        }
    }
}
