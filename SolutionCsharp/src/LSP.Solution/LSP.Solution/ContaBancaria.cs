namespace LSP.Solution
{
    internal class ContaBancaria : IConta
    {
        public decimal Saldo { get; private set; }

        public ContaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente");

            Saldo -= valor;
            Console.WriteLine($"[Conta Bancaria] Saque de {valor}. Saldo: {Saldo}");
        }
    }
}
