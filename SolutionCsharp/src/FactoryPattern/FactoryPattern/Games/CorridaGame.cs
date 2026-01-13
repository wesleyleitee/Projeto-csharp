namespace FactoryPattern.Games
{
    public class CorridaGame : IGame
    {
        public string Tipo => "Corrida";

        public void Start()
        {
            Console.WriteLine("Iniciando jogo de Corrida.");
        }
    }
}
