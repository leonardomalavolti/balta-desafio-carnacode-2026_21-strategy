using DesignPatternChallenge.Infos;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Contexts;

public class ShippingCalculator
{
    private IShippingStrategy _strategy;

    public ShippingCalculator(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal CalculateShipping(ShippingInfo info) => _strategy.CalculateShipping(info);
    public int GetDeliveryTime(ShippingInfo info) => _strategy.GetDeliveryTime(info);
    public bool IsAvailable(ShippingInfo info) => _strategy.IsAvailable(info);
    public string StrategyName => _strategy.Name;
}