using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Model
{
    public interface ICreature
    {
        string Name { get; set; }
        string Description { get; set; }
        uint Age { get; set; }
        string AnimalClass { get; }
        
        
    }
}
