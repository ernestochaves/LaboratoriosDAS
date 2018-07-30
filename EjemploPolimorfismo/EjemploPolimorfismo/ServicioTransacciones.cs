using System;
using System.Collections.Generic;
using System.Linq;
namespace EjemploPolimorfismo
{
    public class ServicioTransacciones
    {
        List<string> trans = new List<string>() {
            DateTime.Now.ToShortDateString() + ": $1000",
            DateTime.Now.ToShortDateString() + ": $10200",
            DateTime.Now.AddDays(-2).ToShortDateString() + ": $1000"
        };

        /// <summary>
        /// Al usar diferentes metodos con diferentes parametros, se evitan logicas complicadas y repeticiones de codigo. 
        /// </summary>
        /// <returns></returns>
        internal List<string> ObtenerTransacciones()
        {
            return trans;
        }

        internal List<string> ObtenerTransacciones(DateTime day)
        {
            return trans
                .Where(t => t.Contains(day.ToShortDateString()))
                .ToList();
        }
    }
}