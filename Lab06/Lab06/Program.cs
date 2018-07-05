using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {

            //Typically, one could do this:
            SmokeSensor sensor = new SmokeSensor();

            //*Without tell dont ask
            //notice this could happen automatically. 
            sensor.CO2 = 100;

            if (sensor.CO2 > sensor.CO2Threshold)
            {
                sensor.SendAlarms();
            }

            //If you go tell dont ask, the class has more behavior. 
            //Instead of checking, you only set CO2 and the class takes over. 

            //With tell dont ask
            sensor.CO2 = 100;




        }
    }
}
