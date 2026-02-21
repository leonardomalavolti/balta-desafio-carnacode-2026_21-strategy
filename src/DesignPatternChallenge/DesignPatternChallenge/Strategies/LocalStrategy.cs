using DesignPatternChallenge.Infos;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Strategies;

public class LocalStrategy : IShippingStrategy
{
    public string Name => "Local";

    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = 8 + info.Weight * 1.5m;
        if (info.IsExpress)
            Console.WriteLine("   ℹ️ Transportadora local sempre entrega rápido");
        if (!info.Destination.Contains("São Paulo-SP"))
        {
            Console.WriteLine("   ❌ Não atende esta região!");
            return 0;
        }
        Console.WriteLine($"→ Cálculo Local: R$ {cost:N2}");
        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info) => 1;

    public bool IsAvailable(ShippingInfo info) => info.Destination.Contains("São Paulo-SP");
}
