namespace StrategyPattern.Strategies
{
    public class DescontoNormalStrategy : IDescontoStrategy
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.05m;
        }
    }
}
