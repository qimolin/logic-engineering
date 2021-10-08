using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace logic_engineering.Test
{
    public class StringHandlerTests
    {
        [Fact]
        public void RemoveWhiteSpace_ShouldReturnStringWithoutSpaces()
        {
            // Arrange
            string sut = "!(~(A ),&(B ,C))";
            string expected = "!(~(A),&(B,C))";
            // Act
            string actual = StringHandler.RemoveWhiteSpace(sut);
            // Assert
            actual.Should().Be(expected);
        }
        [Theory]
        [InlineData("(()))", 2, 3)]
        [InlineData("()", 1, 1)]
        public void ParenthesesCount_StringParam_ShouldReturnParenthesesCount(string input, int expectedOpenBrackets, int expectedClosingBrackets)
        {
            // Arrange
            int open, closing;
            // Act
            (open, closing) = StringHandler.ParenthesesCount(input);
            // Assert
            open.Should().Be(expectedOpenBrackets);
            closing.Should().Be(expectedClosingBrackets);
        }
        [Fact]
        public void IsCharInList_CharInList_ShouldReturnTrue()
        {
            // Arrange
            List<char> charList = new List<char>();
            char a = 'A';
            // Act
            charList.Add(a);
            // Assert
            StringHandler.IsCharInList(charList, a).Should().BeTrue();
            StringHandler.IsCharInList(charList, 'B').Should().BeFalse();
        }
        [Fact]
        public void IsCharInList_EmptyCharList_ShouldReturnFalse()
        {
            // Arrange
            List<char> charList = new List<char>();
            // Act
            // Assert
            StringHandler.IsCharInList(charList, 'a').Should().BeFalse();
        }
        [Fact]
        public void RemoveFirstChar_StringRef_ShouldRemoveFirstCharFromString()
        {
            // Arrange
            string actual = "Hello";
            string expected = "ello";
            // Act
            StringHandler.RemoveFirstChar(ref actual);
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public void RemoveFirstCharWithValue_EmptyString_ShouldThrowArgumentException()
        {
            // Arrange
            string sut = "";
            // Act
            Action act = () => StringHandler.RemoveFirstChar(ref sut);
            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("String is empty");
        }

        [Fact]
        public void ReplaceCharWithString_GivenParameter_ShouldReplaceCharWithParameter()
        {
            // Arrange
            string sut = "(A>B)>(~A|B)";
            // Act
            StringHandler.ReplaceCharWithString(ref sut, '>', "=>");
            // Assert
            sut.Should().Be("(A=>B)=>(~A|B)");
        }
        [Fact]
        public void BinaryGenerator_ShouldAddBinaryNumbersToList()
        {
            // Arrange
            List<string> expectedCases = new List<string>()
            {
                "000",
                "001",
                "010",
                "011",
                "100",
                "101",
                "110",
                "111"
            };
            // Act
            List<string> actualCases = StringHandler.BinaryGenerator(3);
            // Assert
            actualCases.Should().BeEquivalentTo(expectedCases);
        }
        [Fact]
        public void GetDiffIndex_IfStringDiffIsOne_ShouldReturnDiffIndex()
        {
            // Arrange
            string first = "1001", second = "1000";
            int expectedIndex = 3;
            // Act
            int actualIndex = StringHandler.GetDiffIndex(first, second);
            // Assert
            actualIndex.Should().Be(expectedIndex);
        }
        [Fact]
        public void CountCharWithValue_ShouldReturnValueCountInString()
        {
            // Arrange
            string first = "10**";
            int expectedValue = 2;
            // Act
            int actualValue = StringHandler.CountCharWithValue(first, '*');
            // Assert
            actualValue.Should().Be(expectedValue);
        }
        [Fact]
        public void HasSubsequentChar_ShouldReturnTrueIfStringHasSubsequentChar()
        {
            // Arrange
            string invalid = "***";
            string valid = "*10";
            // Act
            // Assert
            StringHandler.HasSubsequentChar(invalid, '1').Should().BeFalse();
            StringHandler.HasSubsequentChar(invalid, '0').Should().BeFalse();
            StringHandler.HasSubsequentChar(valid, '1').Should().BeTrue();
            StringHandler.HasSubsequentChar(valid, '0').Should().BeTrue();
        }
    }
}
