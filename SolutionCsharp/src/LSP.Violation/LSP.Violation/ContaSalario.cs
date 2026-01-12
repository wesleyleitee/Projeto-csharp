using static System.Net.Mime.MediaTypeNames;

namespace LSP.Violation
{
    internal class ContaSalario : ContaBancaria
    {
        public ContaSalario(decimal saldoInicial)
            : base(saldoInicial)
        {
        }

        public override void Sacar(decimal valor)
        {
            //A classe filha tornou o comportamento MAIS RESTRITIVO do que a classe base prometeu.
            //A classe base permitia, a classe filha proibiu

            if (valor > 1000)
                throw new InvalidOperationException(
                    "Conta salário não permite saque acima de 1000"
                );

            base.Sacar(valor);
        }
    }
}
/*
Imagine que alguém te diz: “Você pode passar por essa porta se tiver até 90kg.”
Você pesa 80kg → entra.
Agora alguém troca a porta sem te avisar e diz: “Ah, mas essa aqui só deixa até 60kg.”
Você: confiou na regra original e foi surpreendido

👉 Isso é LSP violado.
*/