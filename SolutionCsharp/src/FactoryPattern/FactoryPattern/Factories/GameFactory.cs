using FactoryPattern.Games;

namespace FactoryPattern.Factories
{
    public class GameFactory : IGameFactory
    {
        public IGame Criar(string gameType)
        {
            return gameType switch
            {
                "Futebol" => new FutebolGame(),
                "Xadrez" => new XadrezGame(),
                "Corrida" => new CorridaGame(),
                _ => throw new ArgumentException("Tipo de jogo inválido")
            };
        }
    }
}
