using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_01
{
#pragma warning disable

    public class Person : Object
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{Name}: дата рождения: {Birthday:d}";
        }
    }

}
