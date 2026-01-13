namespace StrategyPattern.Strategies
{
    public interface IDescontoStrategy
    {
        decimal Calcular(decimal valor);
    }
}
