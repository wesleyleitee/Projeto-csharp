namespace OCP.Solution.Notificacoes
{
    internal class WhatsAppService : INotificacaoService
    {
        public void Enviar(Usuario usuario)
        {
            Console.WriteLine($"WhatsApp enviado para {usuario.Nome}");
        }
    }
}
