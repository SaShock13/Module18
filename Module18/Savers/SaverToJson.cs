using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Savers
{
    internal class SaverToJson : AbstractSaver
    {
        //string fileName;
        //public SaverToJson(string name)
        //{
        //    fileName = name;
        //}
        //public void SaveToFile(string text)
        //{
        //    using (StreamWriter sw = new StreamWriter($"{fileName}.json"))
        //    {
        //        sw.WriteLine(Convert(text));
        //    }
        //}
        //private string Convert(string text) 
        //{
        //    string convertedText = text + "\n - конвертирован в Json";
        //    return convertedText;
        //}

        public override string Convert(string text)
        {
            string convertedText = text + "\n - конвертирован в Json";
                return convertedText;
        }
        public SaverToJson(string name):base(name)
        {
            extension = ".json";
        }
    }
}
