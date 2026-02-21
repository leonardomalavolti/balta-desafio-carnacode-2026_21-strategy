using DesignPatternChallenge.Infos;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Strategies;

public class FedExStrategy : IShippingStrategy
{
    public string Name => "FedEx";

    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = 30 + info.Weight * 5;
        if (info.IsExpress) cost *= 1.8m;
        if (info.Destination.Contains("Norte") || info.Destination.Contains("Nordeste"))
            cost += 20;

        Console.WriteLine($"→ Cálculo FedEx: R$ {cost:N2}");
        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info) => info.IsExpress ? 2 : 5;

    public bool IsAvailable(ShippingInfo info) => info.Weight <= 50;
}

