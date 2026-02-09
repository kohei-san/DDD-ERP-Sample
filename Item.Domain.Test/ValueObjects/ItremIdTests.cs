using System;
using Item.Domain.ValueObjects;
using Xunit;

namespace Item.Domain.Test.ValueObjects
{
    public class ItemIdTests
    {
        [Fact]
        public void Constructor_Valid_SetsValue()
        {
            var id = new ItemId("ABC123");
            Assert.Equal("ABC123", id.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_Invalid_Throws(string? input)
        {
            Assert.Throws<ArgumentException>(() => new ItemId(input!));
        }

        [Fact]
        public void ToString_ReturnsValue()
        {
            var id = new ItemId("X1");
            Assert.Equal("X1", id.ToString());
        }

        [Fact]
        public void ImplicitOperator_Null_ThrowsArgumentNullException()
        {
            ItemId? name = null;
            Assert.Throws<ArgumentNullException>(() =>
            {
                // implicit operator を呼び出す（null を渡した場合、ArgumentNullException を期待）
                string s = name!;
            });
        }

        [Fact]
        public void ExplicitConversion_FromString_CreatesValueObject()
        {
            var id = (ItemId)"Z9"; // explicit operator を利用
            Assert.Equal("Z9", id.Value);
        }

        [Fact]
        public void Equality_ByValue()
        {
            var a = new ItemId("A");
            var b = new ItemId("A");
            Assert.Equal(a, b);
        }
    }
}