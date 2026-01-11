namespace SRP.Solution
{
    internal class UsuarioValidator
    {
        public void Validar(Usuario usuario)
        {
            Console.WriteLine("Validando usuário...");

            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new Exception("Nome inválido");

            if (!usuario.Email.Contains("@"))
                throw new Exception("Email inválido");
        }
    }
}
