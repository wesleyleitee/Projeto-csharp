namespace LSP.Solution
{
    internal class ContaSalario : IConta
    {
        public decimal Saldo { get; private set; }

        public ContaSalario(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }
        public void Sacar(decimal valor)
        {
            if (valor > 1000)
                throw new InvalidOperationException(
                    "Conta salario não permite saque acima de 1000"
                );

            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente");

            Saldo -= valor;
            Console.WriteLine($"[Conta Salario] Saque de {valor}. Saldo: {Saldo}");
        }
    }
}
