using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Model
{
    interface IModel
    {
        ObservableCollection<ICreature> Creatures { get; set; }
        string AnimalsList { get; set; }
    }
}
