using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using FluentAssertions;

namespace logic_engineering.Test
{
    public class TruthTableTests
    {
        [Fact]
        public void GenerateTruthTable_NoParam_ShouldGenerateTruthTableCorrectly()
        {
            // Arrange
            Mock<PropTree> mock1 = new Mock<PropTree>("=(>(A,&(A,b)),|(~(A),C))");
            TruthTable truthTable1 = new TruthTable(mock1.Object);
            List<string[]> expected1 = new List<string[]>();
            expected1.Add(new string[] { "0", "0", "0", "1" });
            expected1.Add(new string[] { "0", "0", "1", "1" });
            expected1.Add(new string[] { "0", "1", "0", "1" });
            expected1.Add(new string[] { "0", "1", "1", "1" });
            expected1.Add(new string[] { "1", "0", "0", "1" });
            expected1.Add(new string[] { "1", "0", "1", "0" });
            expected1.Add(new string[] { "1", "1", "0", "0" });
            expected1.Add(new string[] { "1", "1", "1", "1" });

            Mock<PropTree> mock2 = new Mock<PropTree>("=(>(A,>(a,b)),|(~(A),C))");
            TruthTable truthTable2 = new TruthTable(mock2.Object);
            List<string[]> expected2 = new List<string[]>();
            expected2.Add(new string[] { "0", "0", "0", "0", "1" });
            expected2.Add(new string[] { "0", "0", "0", "1", "1" });
            expected2.Add(new string[] { "0", "0", "1", "0", "1" });
            expected2.Add(new string[] { "0", "0", "1", "1", "1" });
            expected2.Add(new string[] { "0", "1", "0", "0", "1" });
            expected2.Add(new string[] { "0", "1", "0", "1", "1" });
            expected2.Add(new string[] { "0", "1", "1", "0", "1" });
            expected2.Add(new string[] { "0", "1", "1", "1", "1" });
            expected2.Add(new string[] { "1", "0", "0", "0", "0" });
            expected2.Add(new string[] { "1", "0", "0", "1", "0" });
            expected2.Add(new string[] { "1", "0", "1", "0", "1" });
            expected2.Add(new string[] { "1", "0", "1", "1", "0" });
            expected2.Add(new string[] { "1", "1", "0", "0", "1" });
            expected2.Add(new string[] { "1", "1", "0", "1", "1" });
            expected2.Add(new string[] { "1", "1", "1", "0", "0" });
            expected2.Add(new string[] { "1", "1", "1", "1", "1" });
            // Act
            List<string[]> actual1 = truthTable1.GetFullRows();
            List<string[]> actual2 = truthTable2.GetFullRows();
            // Assert
            actual1.Should().BeEquivalentTo(expected1);
            actual2.Should().BeEquivalentTo(expected2);
        }
        [Fact]
        public void GetBinaryString_ShouldReturnBinaryString()
        {
            // Arrange
            Mock<PropTree> mock = new Mock<PropTree>("=(>(A,&(A,b)),|(~(A),C))");
            TruthTable truthTable = new TruthTable(mock.Object);
            string expected = "10011111";
            // Act
            string binaryString = truthTable.GetBinaryString();
            // Assert
            binaryString.Should().Be(expected);
        }
        [Fact]
        public void GetHexaDecimal_ShouldConvertBinaryStringToHexValue()
        {
            // Arrange
            Mock<PropTree> mock = new Mock<PropTree>("=(>(A,&(A,b)),|(~(A),C))");
            TruthTable truthTable = new TruthTable(mock.Object);
            string expected = "9F";
            // Act
            string hexaDeciaml = truthTable.GetHexaDecimal();
            // Assert
            hexaDeciaml.Should().Be(expected);
        }

        [Fact]
        public void ValidateSimplifiedTable_IfRowExistsInInitialTable_ShouldReturnTrue()
        {
            // Arrange
            Mock<PropTree> mock1 = new Mock<PropTree>("|(|(A,B),C)");
            TruthTable truthTable1 = new TruthTable(mock1.Object);
            List<TruthRow> simplifiedOnes1 = new List<TruthRow>();
            simplifiedOnes1.Add(new TruthRow("**1", true));
            simplifiedOnes1.Add(new TruthRow("*1*", true));
            simplifiedOnes1.Add(new TruthRow("1**", true));

            Mock<PropTree> mock2 = new Mock<PropTree>("=(>(A,>(a,b)),|(~(A),C))");
            TruthTable truthTable2 = new TruthTable(mock2.Object);
            List<TruthRow> simplifiedOnes2 = new List<TruthRow>();
            simplifiedOnes2.Add(new TruthRow("*010", true));
            simplifiedOnes2.Add(new TruthRow("*10*", true));
            simplifiedOnes2.Add(new TruthRow("*1*1", true));
            simplifiedOnes2.Add(new TruthRow("0***", true));

            // Act
            // Assert
            truthTable1.ValidateSimplifiedTable(simplifiedOnes1).Should().BeTrue();
            truthTable2.ValidateSimplifiedTable(simplifiedOnes2).Should().BeTrue();
        }
        [Fact]
        public void ValidateSimplifiedTable_IfRowDoesNotExistsInInitialTable_ShouldReturnFalse()
        {
            // Arrange
            Mock<PropTree> mock1 = new Mock<PropTree>("|(|(A,B),C)");
            TruthTable truthTable1 = new TruthTable(mock1.Object);
            List<TruthRow> invalidRows = new List<TruthRow>();
            invalidRows.Add(new TruthRow("*00", true));
            invalidRows.Add(new TruthRow("0*0", true));

            // Act
            // Assert
            truthTable1.ValidateSimplifiedTable(invalidRows).Should().BeFalse();
        }
        [Fact]
        public void SimplifiedRows_ConstructedCorrectly_ShouldReturnTrue()
        {
            // Arrange
            Mock<PropTree> mock = new Mock<PropTree>("=(>(A,>(a,b)),|(~(A),C))");
            TruthTable truthTable = new TruthTable(mock.Object);
            // Act
            List<TruthRow> rows = new List<TruthRow>();
            rows.Add(new TruthRow("*010", true));
            rows.Add(new TruthRow("*10*", true));
            rows.Add(new TruthRow("*1*1", true));
            rows.Add(new TruthRow("0***", true));
            rows.Add(new TruthRow("1110", false));
            rows.Add(new TruthRow("100*", false));
            rows.Add(new TruthRow("10*1", false));
            // Assert
            truthTable.ValidateSimplifiedTable(rows).Should().BeTrue();
        }
        [Fact]
        public void SimplifiedRows_ConstructedIncorrectly_ShouldReturnFalse()
        {
            // Arrange
            Mock<PropTree> mock = new Mock<PropTree>("=(>(A,>(a,b)),|(~(A),C))");
            TruthTable truthTable = new TruthTable(mock.Object);
            // Act
            List<TruthRow> simplifiedTable = new List<TruthRow>();
            simplifiedTable.Add(new TruthRow("****", true));
            // Assert
            truthTable.ValidateSimplifiedTable(simplifiedTable).Should().BeFalse();
        }
        [Theory]
        [InlineData("=(>(A,>(a,b)),|(~(A),C))")]
        // Tautology
        [InlineData("=(>(A,B),|(~(A),B))")]
        // Contradiction
        [InlineData("&(A,~(A))")]
        public void DNF_ShouldHaveSameHashCodeAsInitialTable(string proposition)
        {
            // Arrange
            Mock<PropTree> mock = new Mock<PropTree>(proposition);
            TruthTable truthTable = new TruthTable(mock.Object);
            PropTree dnf = truthTable.DNF();
            TruthTable dnfTable = new TruthTable(dnf);
            // Act
            string actual = truthTable.GetHexaDecimal();
            string expected = dnfTable.GetHexaDecimal();
            // Assert
            expected.Should().Be(actual);
        }
        [Theory]
        [InlineData("=(>(A,>(a,b)),|(~(A),C))")]
        // Tautology
        [InlineData("=(>(A,B),|(~(A),B))")]
        // Contradiction
        [InlineData("&(A,~(A))")]
        public void DNFSimplified_ShouldHaveSameHashCodeAsInitialSimplifiedTable(string proposition)
        {
            // Arrange
            Mock<PropTree> mock = new Mock<PropTree>(proposition);
            TruthTable truthTable = new TruthTable(mock.Object);
            PropTree dnfSimplified = truthTable.DNFSimplified();
            TruthTable dnfSimplifiedTable = new TruthTable(dnfSimplified);
            // Act
            string expected = truthTable.GetSimplifiedHexaDecimal();
            string actual = dnfSimplifiedTable.GetSimplifiedHexaDecimal();
            // Assert
            actual.Should().Be(expected);
        }
    }
}
