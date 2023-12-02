using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Savers
{
    internal abstract class AbstractSaver:ISaver
    {
        string fileName;
        public string extension;

        string fullName;
        public string FullName
        {
            get { return fileName+extension; }
            set { fullName = value; }
        }
        public AbstractSaver(string name)
        {
            fileName = name;
            
        }
        public void SaveToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter($"{FullName}"))
            {
                sw.WriteLine(Convert(text));
            }
        }
        public abstract string Convert(string text);
        

    }
}
