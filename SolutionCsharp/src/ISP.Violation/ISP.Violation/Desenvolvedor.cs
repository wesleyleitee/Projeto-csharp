namespace ISP.Violation
{
    internal class Desenvolvedor : IFuncionario
    {
        public void GerarRelatorio()
        {
            Console.WriteLine("Desenvolvendo código");
        }

        public void GerenciarEquipe()
        {
            // Não faz sentido para um desenvolvedor
            throw new NotImplementedException();
        }

        public void Trabalhar()
        {
            // Também não faz sentido
            throw new NotImplementedException();
        }
    }
}
