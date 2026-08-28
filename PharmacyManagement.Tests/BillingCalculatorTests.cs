using Xunit;
using PharmacyManagement;

namespace PharmacyManagement.Tests;

public class BillingCalculatorTests
{
    [Theory]
    [InlineData(2, 125, 250)]
    [InlineData(1, 99, 99)]
    public void CalculateLineTotal_ReturnsQuantityTimesUnitPrice(int quantity, int unitPrice, int expected)
    {
        Assert.Equal(expected, BillingCalculator.CalculateLineTotal(quantity, unitPrice));
    }

    [Theory]
    [InlineData(0, 100)]
    [InlineData(2, 0)]
    [InlineData(-1, 100)]
    public void CalculateLineTotal_ReturnsZeroForNonPositiveInputs(int quantity, int unitPrice)
    {
        Assert.Equal(0, BillingCalculator.CalculateLineTotal(quantity, unitPrice));
    }

    [Theory]
    [InlineData(4, 4, true)]
    [InlineData(3, 5, true)]
    [InlineData(6, 5, false)]
    [InlineData(0, 5, false)]
    public void CanFulfil_RejectsInvalidOrOverStockRequests(int requested, int available, bool expected)
    {
        Assert.Equal(expected, BillingCalculator.CanFulfil(requested, available));
    }
}
