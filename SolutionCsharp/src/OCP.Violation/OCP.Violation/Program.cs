namespace OCP.Violation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usuarioService = new UsuarioService();

            var usuarioPremium = new Usuario(
                "Wesley",
                "wesley@email.com",
                TipoUsuarioEnum.Premium
            );

            var usuarioBasico = new Usuario(
                "Ana",
                "ana@email.com",
                TipoUsuarioEnum.Basico
            );

            var usuarioConvidado = new Usuario(
                "João",
                "joao@email.com",
                TipoUsuarioEnum.Convidado
            );

            usuarioService.CriarUsuario(usuarioPremium);
            usuarioService.CriarUsuario(usuarioBasico);
            usuarioService.CriarUsuario(usuarioConvidado);

            Console.ReadKey();
        }
    }
}
