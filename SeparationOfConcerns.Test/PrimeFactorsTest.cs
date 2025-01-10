namespace SeparationOfConcerns.Test;

using Xunit;
using SeparationOfConcerns;
using System.Collections.Generic;

public class PrimeFactorsTest
{
    [Fact]
    public void Factor_ShouldReturnCorrectPrimeFactors()
    {
        Assert.Equal(new List<int> { 2, 3, 7 }, PrimeFactors.GetFactors(42));
        Assert.Equal(new List<int> { 3, 3, 11 }, PrimeFactors.GetFactors(99));
        Assert.Equal(new List<int> { 2, 617 }, PrimeFactors.GetFactors(1234));
    }

    [Fact]
    public void Factor_ShouldThrowOnNegativeNumbers()
    {
        Assert.Throws<ArgumentException>(() => PrimeFactors.GetFactors(-42));
    }
}
