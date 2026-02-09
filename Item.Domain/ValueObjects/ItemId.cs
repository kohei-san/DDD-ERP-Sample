using System;

namespace Item.Domain.ValueObjects
{
    public sealed record ItemId
    {
        public string Value { get; }

        public ItemId(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("アイテムIDは必須です。", nameof(value));
            Value = value;
        }

        public override string ToString() => Value;

        // VO → string  null を許容しない暗黙変換
        public static implicit operator string(ItemId c)
        {
            if (c is null)
                throw new ArgumentNullException(nameof(c));

            return c.Value;
        }

        // string → ItemCode は explicit（意図的な変換）
        public static explicit operator ItemId(string s) => new ItemId(s);
    }
}

    