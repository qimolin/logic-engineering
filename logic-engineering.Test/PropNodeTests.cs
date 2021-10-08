using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace logic_engineering.Test
{
    public class PropNodeTests
    {
        [Fact]
        public void Constructor_WithValidParametersIsInitializedProperly()
        {
            // Arrange
            PropNode variable = new Variable('A');
            PropNode bi = new Biimplication();
            PropNode conj = new Conjunction();
            PropNode disj = new Disjunction();
            PropNode impl = new Implication();
            PropNode neg = new Negation();
            // Act

            // Assert
            variable.Value.Should().Be('A');
            bi.Value.Should().Be('=');
            conj.Value.Should().Be('&');
            disj.Value.Should().Be('|');
            impl.Value.Should().Be('>');
            neg.Value.Should().Be('~');
        }
        [Fact]
        public void TruthRow_WithSamePredicateShouldBeLogicallyEqual()
        {
            // Arrange
            PropNode a = new Biimplication();
            PropNode b = new Biimplication();
            // Act

            // Assert
            a.Equals(b).Should().BeTrue();
            a.GetHashCode().Should().Be(b.GetHashCode());
        }

        [Fact]
        public void TruthRow_DifferentCompositeClassesShouldBeInEqual()
        {
            // Arrange
            PropNode a = new Biimplication();
            PropNode b = new Conjunction();
            // Act

            // Assert
            a.Equals(b).Should().BeFalse();
            a.GetHashCode().Should().NotBe(b.GetHashCode());
        }
    }
}
