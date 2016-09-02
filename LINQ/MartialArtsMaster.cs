using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class MartialArtsMaster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Menpai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }

        // alt + insert 选择 formatter
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Menpai: {Menpai}, Kongfu: {Kongfu}, Level: {Level}";
        }
    }
}
