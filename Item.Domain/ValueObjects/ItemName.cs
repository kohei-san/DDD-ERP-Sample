using System;

namespace Item.Domain.ValueObjects
{
    public sealed record ItemName
    {
        public string Value { get; }

        public ItemName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("アイテム名は必須です。", nameof(value));
            if (value.Length > 200)
                throw new ArgumentException("アイテム名は200文字以内で指定してください。", nameof(value));

            Value = value;
        }

        public override string ToString() => Value;

        public static implicit operator string(ItemName c)
        {
            if (c is null)
                throw new ArgumentNullException(nameof(c));

            return c.Value;
        }
        public static explicit operator ItemName(string s) => new ItemName(s);
    }
}