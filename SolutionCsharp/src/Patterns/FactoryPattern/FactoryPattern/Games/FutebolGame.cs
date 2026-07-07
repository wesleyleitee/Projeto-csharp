namespace FactoryPattern.Games
{
    public class FutebolGame : IGame
    {
        public string Tipo => "Futebol";

        public void Start()
        {
            Console.WriteLine("Iniciando jogo de Futebol.");
        }
    }
}
