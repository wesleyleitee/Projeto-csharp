using OCP.Solution.Notificacoes;

namespace OCP.Solution.Estrategias
{
    internal class NotificacaoUsuarioBasico : INotificacaoPorTipoUsuario
    {
        public TipoUsuarioEnum Tipo => TipoUsuarioEnum.Basico;

        // Me devolva uma lista de coisas que sabem enviar notificação
        public IEnumerable<INotificacaoService> ObterNotificacoes()
        {
            return new INotificacaoService[]
            {
                new EmailService()
            };
        }
    }
}
