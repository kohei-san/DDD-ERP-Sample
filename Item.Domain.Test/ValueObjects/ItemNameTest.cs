using System;
using Item.Domain.ValueObjects;
using Xunit;

namespace Item.Domain.Test.ValueObjects
{
    public class ItemNameTests
    {
        [Fact]
        public void Constructor_Valid_SetsValue()
        {
            var name = new ItemName("有効な名前");
            Assert.Equal("有効な名前", name.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_Invalid_Throws_ForNullOrWhiteSpace(string? input)
        {
            Assert.Throws<ArgumentException>(() => new ItemName(input!));
        }

        [Fact]
        public void Constructor_Allows_MaxLength_200()
        {
            var longName = new string('a', 200);
            var name = new ItemName(longName);
            Assert.Equal(longName, name.Value);
        }

        [Fact]
        public void Constructor_Throws_When_Exceeds_MaxLength()
        {
            var tooLong = new string('a', 201);
            Assert.Throws<ArgumentException>(() => new ItemName(tooLong));
        }

        [Fact]
        public void ToString_ReturnsValue()
        {
            var name = new ItemName("サンプル名");
            Assert.Equal("サンプル名", name.ToString());
        }

        [Fact]
        public void ImplicitOperator_Null_ThrowsArgumentNullException()
        {
            ItemName? name = null;
            Assert.Throws<ArgumentNullException>(() =>
            {
                // implicit operator を呼び出す（null を渡した場合、ArgumentNullException を期待）
                string s = name!;
            });
        }

        [Fact]
        public void ImplicitOperator_NonNull_ReturnsString()
        {
            var name = new ItemName("テスト");
            string s = name; // implicit convert
            Assert.Equal("テスト", s);
        }

        [Fact]
        public void ExplicitConversion_FromString_CreatesValueObject()
        {
            var name = (ItemName)"Z9";
            Assert.Equal("Z9", name.Value);
        }

        [Fact]
        public void Equality_ByValue()
        {
            var a = new ItemName("同じ名前");
            var b = new ItemName("同じ名前");
            Assert.Equal(a, b);
        }
    }
}
