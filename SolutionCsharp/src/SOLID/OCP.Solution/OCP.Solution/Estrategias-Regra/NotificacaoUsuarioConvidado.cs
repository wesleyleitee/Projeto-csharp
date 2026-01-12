using OCP.Solution.Notificacoes;

namespace OCP.Solution.Estrategias
{
    internal class NotificacaoUsuarioConvidado : INotificacaoPorTipoUsuario
    {
        public TipoUsuarioEnum Tipo => TipoUsuarioEnum.Convidado;

        public IEnumerable<INotificacaoService> ObterNotificacoes()
        {
            return new INotificacaoService[]
            {
                new SmsService()
            };
        }
    }
}
