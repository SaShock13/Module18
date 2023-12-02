using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Model
{
    interface ICreature
    {
        string Name { get; }
        string Description { get; }
        uint Age { get; }
        string AnimalClass { get; }
        
        
    }
}
