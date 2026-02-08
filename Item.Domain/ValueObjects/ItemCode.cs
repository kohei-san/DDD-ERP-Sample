using System;

namespace Item.Domain.ValueObjects
{
    public sealed record ItemCode
    {
        public string Value { get; }

        public ItemCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("アイテムコードは必須です。", nameof(value));
            Value = value;
        }

        public override string ToString() => Value;

        // null に対して安全に動作するよう変更
        public static implicit operator string(ItemCode? c) => c?.Value;

        public static explicit operator ItemCode(string s) => new ItemCode(s);
    }
}