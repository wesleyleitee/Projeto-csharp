using OCP.Solution.Notificacoes;

namespace OCP.Solution.Estrategias
{
    internal class NotificacaoUsuarioPremium: INotificacaoPorTipoUsuario
    {
        public TipoUsuarioEnum Tipo => TipoUsuarioEnum.Premium;

        public IEnumerable<INotificacaoService> ObterNotificacoes()
        {
            return new INotificacaoService[]
            {
                new EmailService(),
                new WhatsAppService()
            };
        }
    }
}
