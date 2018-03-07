using Xunit;

namespace GameOfLife.Tests
{
    public class LifeTests
    {
        [Fact]
        public void BlinkerPatternTest()
        {
            var life = new Life(10);

            life.ToggleCell(5, 5);
            life.ToggleCell(5, 6);
            life.ToggleCell(5, 7);

            life.BeginGeneration();
            life.Wait();

            Assert.True((life[5, 5]));
            Assert.True((life[5, 6]));
            Assert.True((life[5, 7]));

            life.Update();
            life.Wait();

            Assert.True((life[4, 6]));
            Assert.True((life[5, 6]));
            Assert.True((life[6, 6]));
        }
    }
}
