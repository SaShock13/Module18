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
                case "Amphibian": return new Amphibian(name,desc,age);
                case "Mammal": return new Mammal(name, desc, age);
                case "Bird": return new Bird(name, desc, age);

                default: return new NullCreature();
                }
        }
    }
}
