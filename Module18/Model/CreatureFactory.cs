using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Model
{
    class CreatureFactory
    {
        static public ICreature CreateACreature(string animalClass,string name,string desc,uint age)
        {
            switch (animalClass) 
            {
                case "Земноводные": return new Amphibian(name,desc,age);
                case "Млекопитающие": return new Mammal(name, desc, age);
                case "Птицы": return new Bird(name, desc, age);

                default: return new NullCreature();
                }
        }
    }
}
