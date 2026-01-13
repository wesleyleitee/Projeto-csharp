using FactoryPattern.Games;

namespace FactoryPattern.Factories
{
    //public class GameFactory : IGameFactory
    //{
    //    public IGame Criar(string gameType)
    //    {
    //        return gameType switch
    //        {
    //            "Futebol" => new FutebolGame(),
    //            "Xadrez" => new XadrezGame(),
    //            "Corrida" => new CorridaGame(),
    //            _ => throw new ArgumentException("Tipo de jogo inválido")
    //        };
    //    }
    //}

    public class GameFactory : IGameFactory
    {
        private readonly Dictionary<string, IGame> _games;

        public GameFactory(IEnumerable<IGame> games)
        {
            _games = games.ToDictionary(g => g.Tipo);
        }

        public IGame Criar(string gameType)
        {
            if (!_games.TryGetValue(gameType, out var game))
                throw new ArgumentException("Tipo de jogo inválido");

            return game;
        }
    }
}
