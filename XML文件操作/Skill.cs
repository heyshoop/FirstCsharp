using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML文件操作
{
    class Skill
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  string Lang { get; set; }
        public int Damage { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Lang: {Lang}, Damage: {Damage}";
        }
    }
}
