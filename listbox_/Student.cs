using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listbox_
{
     class Student
    {
        public string Name { get; set; }
        public string Grade { get; set; }

        public override string ToString() => $"{Name} {Grade}";
    }
}
