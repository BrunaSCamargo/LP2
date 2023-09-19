using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;

        private void TxtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
                txtAltura.Focus();
            }
            else
            {
                if (altura <= 0)
                {
                    MessageBox.Show("Altura não deve ser maior que zero");
                    txtAltura.Focus();
                }
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            txtVolume.Text = volume.ToString("N2");
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtRaio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
                txtRaio.Focus();
            }
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("Raio não pode se <=0");
                    txtRaio.Focus();
                }
            }
        }
    }
}
