using StrategyPattern.Strategies;

namespace StrategyPattern.Context
{
    public class CalculadoraDesconto
    {
        private readonly IDescontoStrategy _descontoStrategy;

        public CalculadoraDesconto(IDescontoStrategy descontoStrategy)
        {
            _descontoStrategy = descontoStrategy;
        }

        public decimal Calcular(decimal valor)
        {
            return _descontoStrategy.Calcular(valor);
        }
    }
}
