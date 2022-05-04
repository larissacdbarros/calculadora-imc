using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula73_WF_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Altura = double.Parse(txtAltura.Text)/100;
            p.Peso = double.Parse(txtPeso.Text);
            p.CalculaIMC();
            lblResultadoIMC.Text = p.StatusImc();
        }
    }
}
