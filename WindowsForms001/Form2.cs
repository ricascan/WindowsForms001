using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms001
{
    public partial class Form2 : Form
    {

        RadioButton radioButtonSelected = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            radioButtonSelected = radioButton;
            labelColores.Text = radioButton.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSeleccionado_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(radioButtonSelected.Text);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            switch (Convert.ToInt32(radioButton.Text))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    labelNota.Text = "Suspenso";
                    break;
                case 5:
                    labelNota.Text = "Aprobado";
                    break;
                case 6:
                    labelNota.Text = "Bien";
                    break;
                case 7:
                case 8:
                    labelNota.Text = "Notable";
                    break;
                case 9:
                case 10:
                    labelNota.Text = "Sobresaliente";
                    break;
                default:
                    break;
            }
        }
    }
}
