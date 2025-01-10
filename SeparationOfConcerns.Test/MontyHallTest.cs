namespace SeparationOfConcerns.Test;

using Xunit;
using SeparationOfConcerns;

public class MontyHallTest
{
    [Fact]
    public void Simulate_ShouldSumToTotalGames()
    {
        var games = 100;
        var (stickWins, switchWins) = MontyHall.Simulate(games);

        Assert.Equal(games, stickWins + switchWins);
    }

    [Fact]
    public void Simulate_ShouldHandleZeroGames()
    {
        var (stickWins, switchWins) = MontyHall.Simulate(0);

        Assert.Equal(0, stickWins);
        Assert.Equal(0, switchWins);
    }
}
