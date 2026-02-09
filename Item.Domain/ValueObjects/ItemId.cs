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

        public static implicit operator string?(ItemId? c) => c?.Value;

        public static explicit operator ItemId(string s) => new ItemId(s);
    }
}
    