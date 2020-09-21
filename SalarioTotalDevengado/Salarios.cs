using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioTotalDevengado
{
    public class Salarios : Nomina
    {
        public double CalcularS()
        {
            if (this.getAntiguedadEmpleado() >= 5 && this.getAntiguedadEmpleado() < 7)
            {
                return (this.getSalarioB() * 0.3);
            }
            else
            {


                if (this.getAntiguedadEmpleado() >= 7 && this.getAntiguedadEmpleado() < 10)
                {
                    return (this.getSalarioB() * 0.4);
                }
                else
                {
                    if (this.getAntiguedadEmpleado() == 10)
                    {
                        return (this.getSalarioB() * 0.45);
                    }
                    else
                    {
                        if (this.getAntiguedadEmpleado() > 10)
                        {
                            return (this.getSalarioB() * 0.5);
                        }
                        else
                        {
                            return (this.getSalarioB() * 0);
                        }
                    }

                }

            }

        }
    }

}
