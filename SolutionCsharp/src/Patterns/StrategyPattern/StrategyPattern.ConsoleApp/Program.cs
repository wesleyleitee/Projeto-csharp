using StrategyPattern.Context;
using StrategyPattern.Strategies;

var valor = 1000m;

// Strategy: Desconto Normal
var calculadoraNormal =
    new CalculadoraDesconto(new DescontoNormalStrategy());

Console.WriteLine($"Desconto normal: {calculadoraNormal.Calcular(valor)}");

// Strategy: Desconto Promocional
var calculadoraPromocional =
    new CalculadoraDesconto(new DescontoPromocionalStrategy());

Console.WriteLine($"Desconto promocional: {calculadoraPromocional.Calcular(valor)}");

Console.ReadKey();