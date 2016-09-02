using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Kongfu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Power: {Power}";
        }
    }
}
