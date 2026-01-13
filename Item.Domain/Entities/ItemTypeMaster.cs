using System;

namespace Item.Domain.Entities
{
    public class ItemTypeMaster
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        // ドメイン用コンストラクタ（整合性チェックを行う）
        public ItemTypeMaster(string code, string name)
        {
            if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException("code is required", nameof(code));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name is required", nameof(name));

            Code = code;
            Name = name;
        }

        // EF Core 用（リフレクションでインスタンス化される。ドメインロジックでの使用は想定しない）
        protected ItemTypeMaster()
        {
        }
    }
}
