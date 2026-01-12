using SRP.Solution.Interfaces;

namespace SRP.Solution
{
    internal class EmailService: IEmailService
    {
        public void Enviar(string email)
        {
            Console.WriteLine($"Enviando email de boas-vindas para {email}");
        }
    }
}
