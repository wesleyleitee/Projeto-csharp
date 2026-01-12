namespace ISP.Solution
{
    internal class Gerente : ITrabalhador, IGerente, IRelatorio
    {
        public void GerarRelatorio()
        {
            Console.WriteLine("Gerando relatório");
        }

        public void GerenciarEquipe()
        {
            Console.WriteLine("Gerenciando equipe");
        }

        public void Trabalhar()
        {
            Console.WriteLine("Coordenando atividades");
        }
    }
}
