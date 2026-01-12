namespace LSP.Violation
{
    internal class ContaBancaria
    {
        public decimal Saldo { get; protected set; }

        public ContaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente");

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {Saldo}");
        }
    }
}
