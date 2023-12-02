using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Savers
{
    internal interface ISaver
    {
        void SaveToFile(string text);
    }
}
