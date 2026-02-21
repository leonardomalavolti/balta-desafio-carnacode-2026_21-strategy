using DesignPatternChallenge.Infos;

namespace DesignPatternChallenge.Interfaces;

public interface IShippingStrategy
{
    decimal CalculateShipping(ShippingInfo info);
    int GetDeliveryTime(ShippingInfo info);
    bool IsAvailable(ShippingInfo info);
    string Name { get; }
}