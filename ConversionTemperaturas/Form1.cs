using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Resolver()
        {
            if (txtIngresa.Text != "")
            {
                double dato = Convert.ToDouble(txtIngresa.Text);
                int tipo1 = cobIngresa.SelectedIndex;
                int tipo2 = cobSalida.SelectedIndex;

                switch (tipo1)

                {
                    case 0:
                        if (tipo2 == 0)
                            txtSalida.Text = dato.ToString();

                        if (tipo2 == 1)
                            txtSalida.Text = (dato * 1.8 + 32).ToString();

                        if (tipo2 == 2)
                            txtSalida.Text = (dato + 273.15).ToString();

                        break;

                    case 1:
                        if (tipo2 == 0)
                            txtSalida.Text = ((dato - 32) / 1.8).ToString();

                        if (tipo2 == 1)
                            txtSalida.Text = dato.ToString();

                        if (tipo2 == 2)
                            txtSalida.Text = (((dato - 32) / 1.8) + 273.15).ToString();

                        break;

                    case 2:
                        if (tipo2 == 0)
                            txtSalida.Text = (dato - 273.15).ToString();

                        if (tipo2 == 1)
                            txtSalida.Text = ((dato - 273.15) * 1.8 + 32).ToString();

                        if (tipo2 == 2)
                            txtSalida.Text = dato.ToString();
                        break;
                }

            }
        }

        private void TxtIngresa_TextChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void CobIngresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void CobSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }
    }
}
