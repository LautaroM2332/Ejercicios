using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        Volumen vol = new Volumen();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblOpcion_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dudOpciones_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    cmbOpciones.SelectedIndex = -1;
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(cmbOpciones.SelectedIndex == 0)
            {
                vol.lado = Convert.ToInt32(txtLado.Text);

                txtResultadoV.Text = vol.volCubo(Convert.ToInt32(vol.lado)).ToString();
            }
            else if(cmbOpciones.SelectedIndex == 1)
            {
                vol.radio = Convert.ToInt32(txtRadio.Text);

                txtResultadoV.Text = vol.volEsfera(Convert.ToInt32(vol.radio), Convert.ToDouble(vol.pi)).ToString();
            }
            else
            {
                vol.radio = Convert.ToInt32(txtRadio.Text);
                vol.altura = Convert.ToInt32(txtAltura.Text);

                txtResultadoV.Text = vol.volCilindro(Convert.ToInt32(vol.radio),Convert.ToInt32(vol.altura),Convert.ToDouble(vol.pi)).ToString();
            }
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResultadoV_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
