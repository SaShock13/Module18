using Module18.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.View
{
    interface IView
    {
        public ObservableCollection<ICreature> Creatures { get; set; }


    }
}
