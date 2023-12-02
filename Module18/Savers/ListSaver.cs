using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Savers
{
    internal class ListSaver
    {
        ISaver saveMode;
        public ListSaver(ISaver saver)
        {
            saveMode = saver;
        }

        public void Save(string list)
        {
            saveMode.SaveToFile(list);
        }


    }
}
