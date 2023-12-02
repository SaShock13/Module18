using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Savers
{
    internal class SaverToXmls:AbstractSaver
    {
        public override string Convert(string text)
        {
            string convertedText = text + "\n - конвертирован в Xmls";
            return convertedText;
        }
        public SaverToXmls(string name) : base(name)
        {
            extension = ".xmls";
        }
    }
}
