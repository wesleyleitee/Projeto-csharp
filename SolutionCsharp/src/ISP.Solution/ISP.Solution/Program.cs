using ISP.Solution;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// ISP APLICADO AQUI
services.AddScoped<ITrabalhador, Desenvolvedor>();
services.AddScoped<ITrabalhador, Gerente>();
services.AddScoped<IGerente, Gerente>();
services.AddScoped<IRelatorio, Gerente>();

var provider = services.BuildServiceProvider();

// Consome só o que precisa

var trabalhadores = provider.GetRequiredService<IEnumerable<ITrabalhador>>();

var desenvolvedor = trabalhadores.OfType<Desenvolvedor>().First();
desenvolvedor.Trabalhar();

var gerente = trabalhadores.OfType<Gerente>().First();
gerente.Trabalhar();

Console.ReadKey();
