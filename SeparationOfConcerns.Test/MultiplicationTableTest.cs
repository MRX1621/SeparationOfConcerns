namespace SeparationOfConcerns.Test;

using Xunit;
using SeparationOfConcerns;
using System.Collections.Generic;

public class MultiplicationTableTest
{
    [Fact]
    public void GenerateMultiplicationTable_ShouldProduceCorrectResults()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };

        var table = MultiplicationTable.GenerateTable(numbers);

        Assert.Equal(expected, table);
    }

    [Fact]
    public void GenerateMultiplicationTable_ShouldThrowOnNegativeNumbers()
    {
        var numbers = new List<int> { 1, -2, 3 };

        Assert.Throws<ArgumentException>(() => MultiplicationTable.GenerateTable(numbers));
    }
}
