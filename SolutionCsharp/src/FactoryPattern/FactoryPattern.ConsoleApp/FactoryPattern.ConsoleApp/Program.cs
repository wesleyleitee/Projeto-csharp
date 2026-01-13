using FactoryPattern;
using FactoryPattern.Factories;

Console.WriteLine("Escolha o jogo:");
Console.WriteLine("1 - Futebol");
Console.WriteLine("2 - Xadrez");
Console.WriteLine("3 - Corrida");

var opcao = Console.ReadLine();

string gameType = opcao switch
{
    "1" => "Futebol",
    "2" => "Xadrez",
    "3" => "Corrida",
    _ => throw new ArgumentException("Opção inválida")
};

// Antigo
//var runner = new GameRunner();

// Criação das dependências
IGameFactory factory = new GameFactory();
var runner = new GameRunner(factory);

runner.Run(gameType);

Console.ReadLine();

// Factory Pattern encapsula a criação de objetos, removendo o acoplamento entre quem usa e quem instancia.