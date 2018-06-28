
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Log error information
            ILogger logger = new ConsoleLogger();
            DataService service = new DataService(logger);

        }
    }
}
