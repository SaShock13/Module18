using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Savers
{
    internal class SaverToTxt:AbstractSaver
    {
        public override string Convert(string text)
        {
            string convertedText = text + "\n - конвертирован в Txt";
            return convertedText;
        }
        public SaverToTxt(string name) : base(name)
        {
            extension = ".txt";
        }
    }
}
