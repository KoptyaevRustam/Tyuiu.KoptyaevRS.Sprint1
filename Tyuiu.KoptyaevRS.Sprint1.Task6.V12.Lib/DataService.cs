using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KoptyaevRS.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] parts = value.Split(' ');
            string lastWord = parts[parts.Length - 1];
            string ydoli = value.Substring(0, value.Length - lastWord.Length);
            return ydoli.Contains(lastWord);
        }
    }
}
