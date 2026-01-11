namespace OCP.Solution.Notificacoes
{
    internal class EmailService : INotificacaoService
    {
        public void Enviar(Usuario usuario)
        {
            Console.WriteLine($"Email enviado para {usuario.Email}");
        }
    }
}
