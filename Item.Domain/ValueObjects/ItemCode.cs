public sealed record ItemCode
{
    public string Value { get; }

    public ItemCode(string value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value), "Nullは非許容です。");

        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("アイテムコードは必須です。", nameof(value));

        Value = value;
    }

    public override string ToString() => Value;

    // VO → string  null を許容しない暗黙変換
    public static implicit operator string(ItemCode c)
    {
        if (c is null)
            throw new ArgumentNullException(nameof(c));

        return c.Value;
    }

    // string → ItemCode は explicit（意図的な変換）
    public static explicit operator ItemCode(string s) => new ItemCode(s);
}