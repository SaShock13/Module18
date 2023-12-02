using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Model
{
    class NullCreature : ICreature
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public uint Age { get; set; }
        public string AnimalClass { get; set; }
        public NullCreature()
        {
            Name = "Не определено";
            Description = "Не определено";
            AnimalClass = "Не определено";
            
        }
    }
}
