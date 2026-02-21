using DesignPatternChallenge.Contexts;
using DesignPatternChallenge.Infos;
using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Strategies;

Console.WriteLine("=== Sistema de Cálculo de Frete (Strategy Pattern) ===");

var shipping1 = new ShippingInfo
{
    Origin = "São Paulo-SP",
    Destination = "Rio de Janeiro-RJ",
    Weight = 5.0m,
    IsExpress = false
};

var shipping2 = new ShippingInfo
{
    Origin = "São Paulo-SP",
    Destination = "Manaus-AM",
    Weight = 8.0m,
    IsExpress = true
};

var strategies = new IShippingStrategy[]
{
                new CorreiosStrategy(),
                new FedExStrategy(),
                new DHLStrategy(),
                new LocalStrategy()
};

foreach (var strategy in strategies)
{
    var calculator = new ShippingCalculator(strategy);
    if (calculator.IsAvailable(shipping1))
    {
        calculator.CalculateShipping(shipping1);
        Console.WriteLine($"Prazo: {calculator.GetDeliveryTime(shipping1)} dias úteis\n");
    }
}

Console.WriteLine("✅ Estratégias intercambiáveis, código aberto para extensão e fechado para modificação.");