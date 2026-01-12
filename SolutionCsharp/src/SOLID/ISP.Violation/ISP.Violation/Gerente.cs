using ISP.Violation;

internal class Gerente : IFuncionario
{
    public void Trabalhar()
    {
        Console.WriteLine("Coordenando atividades");
    }

    public void GerenciarEquipe()
    {
        Console.WriteLine("Gerenciando equipe");
    }

    public void GerarRelatorio()
    {
        Console.WriteLine("Gerando relatório");
    }
}