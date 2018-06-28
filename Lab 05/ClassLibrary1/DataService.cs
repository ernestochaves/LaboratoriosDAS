using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DataService
    {
        ILogger logger;
        public DataService(ILogger logger) {
            this.logger = logger;
        }

        public void Save()
        {
            //Saves some info to a files. 
            logger.Log("some error happened!", DateTime.Now);
        }
    }
}
