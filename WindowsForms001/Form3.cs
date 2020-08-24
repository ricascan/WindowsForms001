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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            

        }

        private void radioButtonBasico_CheckedChanged(object sender, EventArgs e)
        {
            labelEdad.Visible = false;
            labelTelefono.Visible = false;
            textBoxEdad.Visible = false;
            textBoxTelefono.Visible = false;
        }

        private void radioButtonAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            labelEdad.Visible = true;
            labelTelefono.Visible = true;
            textBoxEdad.Visible = true;
            textBoxTelefono.Visible = true;
        }

        private void buttonInformatico_Click(object sender, EventArgs e)
        {
            if (checkBoxEsInformatico.Checked)
            {
                MessageBox.Show("La caja está chequeada.");
            }
            else
            {
                MessageBox.Show("La caja no está chequeada.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ListControl).Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("insuficiente");
            comboBox1.Items.Add("suficiente");
            comboBox1.Items.Add("bien");
            comboBox1.Items.Add("notable");
            comboBox1.Items.Add("sobresaliente");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = "";
            foreach (String s in listBox1.SelectedItems)
            {
                texto += s + "\n";
            }
            MessageBox.Show(texto);
        }
    }
}
