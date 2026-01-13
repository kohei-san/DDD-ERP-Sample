using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Entities
{
    public class UnitMaster
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        public UnitMaster(string code, string name)
        {
            if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException("code is required", nameof(code));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name is required", nameof(name));

            Code = code;
            Name = name;

        }
        protected UnitMaster() { }
    }
}
