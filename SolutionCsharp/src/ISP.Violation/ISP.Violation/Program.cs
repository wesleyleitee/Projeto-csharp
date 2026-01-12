using ISP.Violation;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// ISP VIOLATION ACONTECE AQUI
services.AddScoped<IFuncionario, Desenvolvedor>();

var provider = services.BuildServiceProvider();

var funcionario = provider.GetRequiredService<IFuncionario>();
funcionario.Trabalhar();

Console.ReadKey();
