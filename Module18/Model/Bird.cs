using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Module18.Model
{
    class Bird : ICreature
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public uint Age { get; set; }
        public string AnimalClass { get; set; }
        public Bird()
        {
            AnimalClass = "Птицы";
        }
        public Bird(string name, string desc, uint age)
        {
            Name = name;
            Description = desc;
            AnimalClass = "Птицы";
            Age = age;
        }
    }
}
