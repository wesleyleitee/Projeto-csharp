using FactoryPattern.Games;

namespace FactoryPattern.Factories
{
    public interface IGameFactory
    {
        IGame Criar(string gameType);
    }
}
