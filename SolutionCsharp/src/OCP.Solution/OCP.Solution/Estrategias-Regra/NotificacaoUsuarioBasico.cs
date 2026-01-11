using OCP.Solution.Notificacoes;

namespace OCP.Solution.Estrategias
{
    // Classe de configuração de regra
    // Se o usuário for Básico, então as notificações são essa aqui
    internal class NotificacaoUsuarioBasico : INotificacaoPorTipoUsuario
    {
        public TipoUsuarioEnum Tipo => TipoUsuarioEnum.Basico;

        // Me devolva uma lista de coisas que sabem enviar notificação
        // Só de eu retornar um tipo interface, eu posso retornar qualquer classe que implementa a interface.
        // Polimorfismo por substituição
        public IEnumerable<INotificacaoService> ObterNotificacoes()
        {
            return new INotificacaoService[]
            {
                new EmailService()
            };
        }
    }
}
