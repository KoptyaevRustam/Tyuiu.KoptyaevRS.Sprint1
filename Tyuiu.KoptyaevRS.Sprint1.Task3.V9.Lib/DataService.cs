using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KoptyaevRS.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
            return minutes / 60;
        }
        public double ConvertMinutesToMinutes(int minutes)
        {
            return minutes - minutes / 60 * 60;
        }
    }
}
