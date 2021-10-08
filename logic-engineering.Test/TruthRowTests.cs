using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace logic_engineering.Test
{
    public class TruthRowTests
    {
        private static string VALID_BINARYCASE = "1111";
        [Fact]
        public void Constructor_WithValidParametersIsInitializedProperly()
        {
            // Arrange
            TruthRow sut = new TruthRow(VALID_BINARYCASE, true);
            // Act
            string[] fullRow = { "1", "1", "1", "1", "1" };

            // Assert
            sut.Result.Should().Be(true);
            sut.BinaryCase.Should().Be(VALID_BINARYCASE);
            sut.FullRow.Should().BeEquivalentTo(fullRow);
            sut.Valid.Should().BeTrue();
        }
        [Fact]
        public void TruthRow_WithSamePredicateShouldBeLogicallyEqual()
        {
            // Arrange
            TruthRow a = new TruthRow("1111", true);
            TruthRow b = new TruthRow("1111", true);
            // Act
            
            // Assert
            a.Equals(b).Should().BeTrue();
            a.GetHashCode().Should().Be(b.GetHashCode());
        }
    }
}
