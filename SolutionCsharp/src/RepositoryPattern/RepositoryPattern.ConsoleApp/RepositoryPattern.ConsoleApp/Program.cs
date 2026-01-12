using RepositoryPattern.Repositories;
using RepositoryPattern.Services;

Console.WriteLine("Iniciando aplicação...");

// Cria o repository concreto
IUsuarioRepository repository = new UsuarioRepository();

// Injeta no service
var usuarioService = new UsuarioService(repository);

// Executa o caso de uso
usuarioService.CriarUsuario("Wesley", "wesley@email.com");

Console.WriteLine("Usuário criado com sucesso!");

Console.ReadLine();

/*
 Repository Pattern separa a regra de negócio do acesso a dados, fazendo o código depender de interfaces, não de implementações.
 */