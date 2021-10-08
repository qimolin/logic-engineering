using System;
using Xunit;
using Moq;
using FluentAssertions;
using System.IO;
using System.Collections.Generic;

namespace logic_engineering.Test
{
    public class PropTreeTests
    {
        [Fact]
        public void ValidateProposition_EmptyProposition_ShouldThrowInvalidArgumentException()
        {
            // Arrange
            string invalidProposition = "";
            // Act
            Action act = () => PropTree.ValidateProposition(invalidProposition);
            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Empty proposition");
        }
        [Fact]
        public void ValidateProposition_UnbalancedParenthesesProposition_ShouldThrowInvalidArgumentException()
        {
            // Arrange
            string invalidProposition = "=(>(A,B),|(~(A),B)";
            // Act
            Action act = () => PropTree.ValidateProposition(invalidProposition);
            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Unbalanced parentheses count");
        }
        [Fact]
        public void ValidateProposition_NoParenthesesProposition_ShouldThrowInvalidArgumentException()
        {
            // Arrange
            string invalidProposition = "!~A,&B,C";
            // Act
            Action act = () => PropTree.ValidateProposition(invalidProposition);
            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Proposition without parentheses is invalid");
        }
        [Fact]
        public void ValidateProposition_NoOperatorsProposition_ShouldThrowInvalidArgumentException()
        {
            // Arrange
            string invalidProposition = "(bad)";
            // Act
            Action act = () => PropTree.ValidateProposition(invalidProposition);
            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Proposition without operators is invalid");
        }
        [Fact]
        public void BuildTree_RefPropositionParam_ShouldConstructTreeCorrectly()
        {
            // Arrange
            PropTree tree1;
            PropTree tree2;
            // Act
            tree1 = new PropTree("=(>(A,&(a,b)),|(~(A),>(A,C)))");
            tree2 = new PropTree("=(>(A,>(a,|(A,b))),|(~(A),>(A,>(A,C))))");
            // Assert
            tree1.Root.Left.Right.Left.Value.Should().Be('a');
            tree1.Root.Right.Left.Right.Value.Should().Be('A');
            tree2.Root.Left.Right.Right.Left.Value.Should().Be('A');
            tree2.Root.Right.Right.Right.Right.Value.Should().Be('C');
        }
        [Fact]
        public void BuildTree_InvalidCharacterInProposition_ShouldThrowInvalidArgumentException()
        {
            // Arrange
            Action act = () => new PropTree("(-A|B)");
            // Act/Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Invalid proposition");

        }
        [Fact]
        public void WriteToFile_FileNameParam_FileShouldExist()
        {
            // Arrange
            PropTree tree = new PropTree("=(>(A,&(a,b)),|(~(A),>(A,C)))");
            // Act
            tree.WriteToFile("abc.dot");
            // Assert
            File.Exists("abc.dot").Should().BeTrue();
        }
        [Fact]
        public void GenerateImage_CreatesImageFromDotFile_ImageShouldExist()
        {
            // Arrange
            PropTree tree = new PropTree("=(>(A,&(a,b)),|(~(A),>(A,C)))");
            // Act
            tree.WriteToFile("abc.dot");
            tree.GenerateImage();
            // Assert
            File.Exists("abc.png").Should().BeTrue();
        }
        [Fact]
        public void ToDotFormat_RootNodeAsParam_ShouldReturnTreeInDotFormat()
        {
            // Arrange
            PropTree tree = new PropTree("=(>(A,&(a,b)),|(~(A),>(A,C)))");
            string expected = "node0 [ label = \"=\" ]node0--node1\r\n" +
                "node1 [ label = \">\" ]node1--node2\r\n" +
                "node2 [ label = \"A\" ]node1--node3\r\n" +
                "node3 [ label = \"&\" ]node3--node4\r\n" +
                "node4 [ label = \"a\" ]node3--node5\r\n" +
                "node5 [ label = \"b\" ]node0--node6\r\n" +
                "node6 [ label = \"|\" ]node6--node7\r\n" +
                "node7 [ label = \"~\" ]node7--node8\r\n" +
                "node8 [ label = \"A\" ]node6--node9\r\n" +
                "node9 [ label = \">\" ]node9--node10\r\n" +
                "node10 [ label = \"A\" ]node9--node11\r\n" +
                "node11 [ label = \"C\" ]";
            // Act
            string actual = tree.ToDotFormat(tree.Root);
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public void ToInfix_CallsToInfixAscii_ShouldReturnPropInInfix()
        {
            // Arrange
            PropTree tree = new PropTree("=(>(A,&(a,b)),|(~(A),>(A,C)))");
            string expected = "(A⇒(a⋀b))⇔(¬A⋁(A⇒C))";
            // Act
            string actual = tree.ToInfix();
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public void GetUniqueVariables_ValidTree_ShouldReturnSortedVariable()
        {
            // Arrange
            PropTree tree = new PropTree("&(A,B)");
            // Act
            List<char> variables = tree.GetUniqueVariables();
            // Assert
            variables.Should().ContainInOrder('A', 'B');
        }
        [Fact]
        public void GetUniqueOperators_ValidTree_ShouldReturnsOperators()
        {
            // Arrange
            PropTree tree = new PropTree("&(A,B)");
            // Act
            List<char> variables = tree.GetUniqueOperators();
            // Assert
            variables.Should().Contain('&');
        }
        [Theory]
        [InlineData("=(>(A,>(a,b)),|(~(A),C))")]
        // Tautology
        [InlineData("=(>(A,B),|(~(A),B))")]
        // Contradiction
        [InlineData("&(A,~(A))")]
        public void Nandify_NandTree_ShouldHaveSameHashCode(string proposition)
        {
            // Arrange
            PropTree tree = new PropTree(proposition);
            TruthTable table  = new TruthTable(tree);
            PropTree nandTree = tree.Nandify();
            TruthTable nandTable = new TruthTable(nandTree);
            // Act
            string expected = table.GetHexaDecimal();
            string actual = nandTable.GetHexaDecimal();
            string simplifiedExpected = table.GetSimplifiedHexaDecimal();
            string simplifiedActual = table.GetSimplifiedHexaDecimal();
            // Assert
            actual.Should().Be(expected);
            simplifiedActual.Should().Be(simplifiedExpected);
        }
    }
}
