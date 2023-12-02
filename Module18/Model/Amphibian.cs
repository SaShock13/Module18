using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Module18.Model
{
    class Amphibian:ICreature
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public uint Age { get; set; }

        public string AnimalClass { get; set; }
        public Amphibian(string name, string desc, uint age)
        {
            Name = name;
            Description = desc;
            AnimalClass = "Земноводные";
            Age = age;
        }
    }
}
