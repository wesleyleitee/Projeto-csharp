using System;

namespace LSP.Violation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Conta Bancaria ===");

            ContaBancaria conta1 = new ContaBancaria(2000);
            conta1.Sacar(1500); // OK

            Console.WriteLine();
            Console.WriteLine("=== Conta Salario ===");

            ContaBancaria conta2 = new ContaSalario(2000);
            conta2.Sacar(1500); // 💥 QUEBRA AQUI

            Console.ReadKey();
        }
    }
}
