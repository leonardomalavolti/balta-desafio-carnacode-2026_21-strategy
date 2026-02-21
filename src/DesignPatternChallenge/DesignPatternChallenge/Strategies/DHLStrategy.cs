using DesignPatternChallenge.Infos;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Strategies;

public class DHLStrategy : IShippingStrategy
{
    public string Name => "DHL";

    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = 25 + info.Weight * 4.5m;
        if (info.Weight > 10) cost += (info.Weight - 10) * 2;
        if (info.IsExpress) cost += 35;

        Console.WriteLine($"→ Cálculo DHL: R$ {cost:N2}");
        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info) => info.IsExpress ? 1 : 4;

    public bool IsAvailable(ShippingInfo info) => info.Weight <= 50;
}

