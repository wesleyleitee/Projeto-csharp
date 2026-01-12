using SRP.Solution.Interfaces;

namespace SRP.Solution
{
    public class UsuarioService
    {
        private readonly IUsuarioValidator _validator;
        private readonly IUsuarioRepository _repository;
        private readonly IEmailService _emailService;

        public UsuarioService(
            IUsuarioValidator validator,
            IUsuarioRepository repository,
            IEmailService emailService)
        {
            _validator = validator;
            _repository = repository;
            _emailService = emailService;
        }

        public void CriarUsuario(string nome, string email)
        {
            var usuario = new Usuario(nome, email);

            _validator.Validar(usuario);
            _repository.Salvar(usuario);
            _emailService.Enviar(usuario.Email);
        }
    }

}
