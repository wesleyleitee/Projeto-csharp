using DIP.Solution;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

//Escolha da implementação
services.AddScoped<IMotor, MotorCombustao>();
services.AddScoped<IMotor, MotorEletrico>();

var carro = new Carro(new MotorCombustao());
carro.Andar();

var carro2 = new Carro(new MotorEletrico());
carro2.Andar();

Console.ReadKey();
