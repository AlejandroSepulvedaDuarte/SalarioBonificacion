using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioTotalDevengado
{
    public class Nomina
    {
        private double SalarioB;
        private double AntiguedadEmpleado;
        public Nomina()
        {
            double minimo;
            minimo = 900000;
            this.SalarioB = minimo;
        }
        public void setAntiguedadEmpleado(double valor)
        {
            this.AntiguedadEmpleado = valor;
        }

        public double getAntiguedadEmpleado()
        {
            return this.AntiguedadEmpleado;
        }
        public double getSalarioB()
        {
            return this.SalarioB;
        }
    }
    
}
