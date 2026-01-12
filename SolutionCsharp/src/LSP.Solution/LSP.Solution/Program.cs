namespace LSP.Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Conta Bancaria ===");
            IConta conta1 = new ContaBancaria(2000);
            conta1.Sacar(1500);

            Console.WriteLine();

            Console.WriteLine("=== Conta Salario ===");
            IConta conta2 = new ContaSalario(2000);
            conta2.Sacar(800);

            Console.ReadKey();
        }
    }
}

// Herança carrega promessas. Interfaces definem capacidades.