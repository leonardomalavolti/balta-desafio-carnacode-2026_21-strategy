using DesignPatternChallenge.Infos;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Strategies;

public class CorreiosStrategy : IShippingStrategy
{
    public string Name => "Correios";

    public decimal CalculateShipping(ShippingInfo info)
    {
        decimal cost = 15 + info.Weight * 2.5m;
        if (info.IsExpress) cost += 25m;
        if (info.Origin.Split('-')[1] == info.Destination.Split('-')[1])
            cost *= 0.85m;

        Console.WriteLine($"→ Cálculo Correios: R$ {cost:N2}");
        return cost;
    }

    public int GetDeliveryTime(ShippingInfo info) => info.IsExpress ? 3 : 7;

    public bool IsAvailable(ShippingInfo info) => true;
}
