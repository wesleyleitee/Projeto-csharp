using OCP.Solution.Notificacoes;

namespace OCP.Solution.Estrategias
{
    internal interface INotificacaoPorTipoUsuario
    {
        TipoUsuarioEnum Tipo { get; }
        IEnumerable<INotificacaoService> ObterNotificacoes();
    }
}
