using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioTotalDevengado
{
     public class SalasrioF:Salarios
     {
        public double total()
        {
            return (this.getSalarioB() + this.CalcularS());
        }
     }
}
