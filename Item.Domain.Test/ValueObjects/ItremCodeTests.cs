using System;
using Item.Domain.ValueObjects;
using Xunit;

namespace Item.Domain.Test.ValueObjects
{
    public class ItemCodeTests
    {
        [Fact]
        public void Constructor_Valid_SetsValue()
        {
            var code = new ItemCode("ABC123");
            Assert.Equal("ABC123", code.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_Invalid_Throws(string? input)
        {
            Assert.Throws<ArgumentException>(() => new ItemCode(input!));
        }

        [Fact]
        public void ToString_ReturnsValue()
        {
            var code = new ItemCode("X1");
            Assert.Equal("X1", code.ToString());
        }

        [Fact]
        public void ImplicitOperator_NullSafe_ReturnsNullString()
        {
            ItemCode? code = null;
            Assert.Throws<ArgumentNullException>(() =>
            {
                string s = code; // implicit operator を呼び出す
            });

        }

        [Fact]
        public void ExplicitConversion_FromString_CreatesValueObject()
        {
            var code = (ItemCode)"Z9"; // explicit operator を利用
            Assert.Equal("Z9", code.Value);
        }

        [Fact]
        public void Equality_ByValue()
        {
            var a = new ItemCode("A");
            var b = new ItemCode("A");
            Assert.Equal(a, b);
        }
    }
}