using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Option
    {
        public string Name { get; }
        public Action Selected { get; }

        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }

    }
}
