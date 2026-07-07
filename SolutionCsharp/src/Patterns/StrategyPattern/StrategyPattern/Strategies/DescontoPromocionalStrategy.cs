namespace StrategyPattern.Strategies
{
    public class DescontoPromocionalStrategy : IDescontoStrategy
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.15m;
        }
    }
}
