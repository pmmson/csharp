using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Task4
{
    public class DataRun
    {
        string dayRun;
        double distance;
        double timeRun;

        public string DayRun
        {
            get { return dayRun; }
            set { dayRun = value; }
        }
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public double TimeRun
        {
            get { return timeRun; }
            set { timeRun = value; }
        }

        public DataRun()
        {

        }
        public DataRun(string dayRun, double distance, double timeRun)
        {
            this.dayRun = dayRun;
            this.distance = distance;
            this.timeRun = timeRun;
        }

        public override string ToString()
        {
            return $"{DayRun} {Distance} км {TimeRun} мин";
        }
    }
}
