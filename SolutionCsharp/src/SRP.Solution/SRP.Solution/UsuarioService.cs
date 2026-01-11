namespace SRP.Solution
{
    internal class UsuarioService
    {
        private readonly UsuarioValidator _validator;
        private readonly UsuarioRepository _repository;
        private readonly EmailService _emailService;

        public UsuarioService()
        {
            _validator = new UsuarioValidator();
            _repository = new UsuarioRepository();
            _emailService = new EmailService();
        }

        public void CriarUsuario(string nome, string email)
        {
            var usuario = new Usuario(nome, email);

            _validator.Validar(usuario);
            _repository.Salvar(usuario);
            _emailService.EnviarBoasVindas(usuario.Email);
        }
    }

}
