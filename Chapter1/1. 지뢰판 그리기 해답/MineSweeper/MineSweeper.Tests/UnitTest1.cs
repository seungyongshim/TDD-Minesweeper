using System;
using System.IO;
using Xunit;
using FluentAssertions;

namespace MineSweeper.Tests
{
    public class MainTest
    {
        [Fact]
        public void Should_Console_WriteLine_Expected_Array()
        {
            // Arrange
            char[,] expectedArray = new char[9,9]
            {
                { '0', '1', '1', '1', '0', '0', '1', '1', '1' },
                { '0', '1', '*', '1', '0', '0', '1', '*', '1' },
                { '0', '1', '1', '2', '1', '1', '1', '2', '2' },
                { '1', '1', '0', '2', '*', '2', '1', '*', '1' },
                { '*', '2', '1', '3', '*', '3', '2', '2', '1' },
                { '1', '2', '*', '2', '1', '2', '*', '1', '0' },
                { '1', '2', '2', '2', '1', '2', '1', '1', '0' },
                { '1', '*', '1', '1', '*', '2', '0', '0', '0' },
                { '1', '1', '1', '1', '1', '1', '0', '0', '0' },
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Program.Main(null);

                using (var sr = new StringReader(sw.ToString()))
                {

                    // Assert
                    for (int j = 0; j < expectedArray.GetLength(0); j++)
                    {
                        string line = sr.ReadLine();
                        string[] lineitems = line.Trim().Split(' ', ',', ':');

                        for (int i = 0; i < expectedArray.GetLength(1); i++)
                        {
                            lineitems[i].Length.Should().Be(1);
                            lineitems[i][0].Should().Be(expectedArray[j, i], $"[{j}, {i}]");
                        }
                    }
                }
            }
        }
    }
}
