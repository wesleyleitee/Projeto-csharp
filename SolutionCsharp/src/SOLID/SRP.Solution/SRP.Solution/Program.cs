using SRP.Solution;

var validator = new UsuarioValidator();
var repository = new UsuarioRepository();
var emailService = new EmailService();

var usuarioService = new UsuarioService(
    validator,
    repository,
    emailService
);

usuarioService.CriarUsuario("Wesley", "wesley@email.com");

Console.ReadKey();