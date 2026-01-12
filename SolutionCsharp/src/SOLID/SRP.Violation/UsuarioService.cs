namespace SRP.Violation
{
    public class UsuarioService
    {
        public void CriarUsuario(string nome, string email)
        {
            // 1. Validação
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome inválido");

            if (!email.Contains("@"))
                throw new Exception("Email inválido");

            // 2. Persistência
            Console.WriteLine("Salvando usuário no banco de dados...");

            // 3. Envio de email
            Console.WriteLine($"Enviando email de boas-vindas para {email}");
        }
    }
}
