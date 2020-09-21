using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioTotalDevengado
{
    public partial class Form1 : Form
    {
        Nomina nomina = new Nomina();
        Salarios salarios = new Salarios();
        SalasrioF salasrioF = new SalasrioF();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcularS_Click(object sender, EventArgs e)
        {
            lblSalariob.Text = Convert.ToString(String.Format("{0:n}", nomina.getSalarioB()));
            salarios.setAntiguedadEmpleado(double.Parse(txtAntiguedad.Text));
            lblant.Text = Convert.ToString(String.Format("{0:n}", salarios.CalcularS()));
            salasrioF.setAntiguedadEmpleado(double.Parse(txtAntiguedad.Text));
            lblValorSF.Text= Convert.ToString(String.Format("{0:n}", salasrioF.total()));

            lblSalariob.Visible = true;
            lblValorSF.Visible = true;
            lblant.Visible = true;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtAntiguedad.Text = String.Empty;
            lblSalariob.Text = String.Empty;
            lblValorSF.Text = String.Empty;
            lblant.Text = String.Empty;
            txtAntiguedad.Focus();

        }
    }
}
