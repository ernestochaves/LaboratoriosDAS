using System;

namespace Lab06
{
    /// <summary>
    /// Provides AIR information 
    /// </summary>
    public class SmokeSensor
    {

        //This full property is more ask dont tell
        //private double cO2;
        //public double CO2
        //{
        //    get { return cO2; }
        //    set
        //    {
        //        cO2 = value;
        //        if (value > CO2Threshold)
        //            SendAlarms();
        //    }
        //}

        public double CO2 { get; set; }

        public double CO2Threshold { get; set; }

        public void SendAlarms()
        {
            //TODO: Add some alarm system
        }
    }
}