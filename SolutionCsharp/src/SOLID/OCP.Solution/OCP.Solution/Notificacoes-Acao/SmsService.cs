namespace OCP.Solution.Notificacoes
{
    internal class SmsService : INotificacaoService
    {
        public void Enviar(Usuario usuario)
        {
            Console.WriteLine($"SMS enviado para {usuario.Nome}");
        }
    }
}
