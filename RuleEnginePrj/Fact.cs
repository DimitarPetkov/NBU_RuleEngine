using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleEnginePrj
{
    class Fact
    {
        private string name;
        private string value;

        public Fact(string name)
        {
            this.name = name;
        }

        public Fact(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public void setValue(string value)
        {
            this.value = value;
        }
    }
}
