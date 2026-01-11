namespace OCP.Solution
{
    internal class Usuario
    {
        public string Nome { get; }
        public string Email { get; }
        public TipoUsuarioEnum Tipo { get; }

        public Usuario(string nome, string email, TipoUsuarioEnum tipo)
        {
            Nome = nome;
            Email = email;
            Tipo = tipo;
        }
    }
}
