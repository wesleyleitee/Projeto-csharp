using FactoryPattern.Factories;
using FactoryPattern.Games;

namespace FactoryPattern
{
    /*
    public class GameRunner
    {
        // Criação fora das boas práticas
        // Isso viola:
        //    OCP (Open/Closed)
        //    SRP (decide e executa)
        //    DIP (depende de classes concretas)
         
        public void Run(string gameType)
        {
            IGame game;

            if (gameType == "Futebol")
            {
                game = new FutebolGame();
            }
            else if (gameType == "Xadrez")
            {
                game = new XadrezGame();
            }
            else if (gameType == "Corrida")
            {
                game = new CorridaGame();
            }
            else
            {
                throw new ArgumentException("Tipo de jogo inválido");
            }

            game.Start();
        }
    }
    */

    public class GameRunner
    {
        private readonly IGameFactory _gameFactory;

        public GameRunner(IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
        }

        public void Run(string gameType)
        {
            IGame game = _gameFactory.Criar(gameType);
            game.Start();
        }
    }

}

/* 
“Esse código usa Strategy?”
“Sim. O Strategy está representado pela interface IGame e suas implementações. 
O GameRunner atua como o contexto, delegando a execução do comportamento (Start) após obter a estratégia via Factory.”
 */