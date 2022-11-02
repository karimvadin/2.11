using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    [Serializable]
    internal class Student
    {
        public string name { get; set; }
        public string group { get; set; }

        [NonSerialized]
        public string numtelephone;
    }
}
