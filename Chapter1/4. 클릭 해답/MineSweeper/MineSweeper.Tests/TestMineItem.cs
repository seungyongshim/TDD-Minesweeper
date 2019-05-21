using FluentAssertions;
using Xunit;

namespace MineSweeper.Tests
{
    public class MineItemSpec
    {
        [Fact]
        public void Should_MineItem_Bomb()
        {
            // Arrange
            char expectValue = '*';

            // Act
            var actualMineItem = new MineItem { IsBomb = true };

            // Assert
            actualMineItem.Value.Should().Be(expectValue);
        }

        [Fact]
        public void Should_MineItem_Not_Bomb_Showing_Number()
        {
            // Arrange
            char expectValue = '1';

            // Act
            var actualMineItem = new MineItem
            {
                IsBomb = false,
                NearBombsCount = 1
            };

            // Assert
            actualMineItem.Value.Should().Be(expectValue);
        }
    }
}
