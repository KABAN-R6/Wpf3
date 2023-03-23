using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf3
{
    class task
    {
        public string Name { get; set; } = "";
        public string time { get; set; }
        //public override string ToString() => $"{Name} ({time})";
        public override string ToString()
        {
            return $"Name: {Name} Age: {time}";
        }
    }
}
