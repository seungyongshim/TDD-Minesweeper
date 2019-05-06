using Xunit;
using FluentAssertions;

namespace MineSweeper.Tests
{
    public class TestMineMap
    {
        [Fact]
        public void Should_Generated_All_Near_Bombs_Count()
        {
            // Arrange
            var expectedMineItems = new MineItem[9, 9]
            {
                {
                    new MineItem{IsBomb =false, NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 1}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 2}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 1}
                },
                {
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 3},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 3},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 0}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 0}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb = true},
                    new MineItem{IsBomb =false,NearBombsCount = 2},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 0}
                },
                {
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 1},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 0},
                    new MineItem{IsBomb =false,NearBombsCount = 0}
                },
            };

            var actualMineMap = new MineMap(9, 9);

            actualMineMap[1, 2].IsBomb = true;
            actualMineMap[1, 7].IsBomb = true;
            actualMineMap[3, 4].IsBomb = true;
            actualMineMap[3, 7].IsBomb = true;
            actualMineMap[4, 0].IsBomb = true;
            actualMineMap[4, 4].IsBomb = true;
            actualMineMap[5, 2].IsBomb = true;
            actualMineMap[5, 6].IsBomb = true;
            actualMineMap[7, 1].IsBomb = true;
            actualMineMap[7, 4].IsBomb = true;


            // Act
            actualMineMap.GenerateAllNearBombsCount();

            // Assert
            for (int j = 0; j < actualMineMap.Height; j++)
            {
                for (int i = 0; i < actualMineMap.Width; i++)
                {
                    actualMineMap[j, i].Value.Should().Be(expectedMineItems[j, i].Value);
                }
            }
        }
    }
}
