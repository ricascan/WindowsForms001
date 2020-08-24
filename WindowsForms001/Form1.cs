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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola desde Windows Forms.");
        }

        private void buttonPersona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + textBoxNombre.Text + ", Apellidos: " + textBoxApellidos.Text);
        }

        private void buttonSumarNotas_Click(object sender, EventArgs e)
        {
            try { 
            double nota1, nota2, nota3;
            nota1 = Convert.ToDouble(textBoxNota1.Text);
            nota2 = Convert.ToDouble(textBoxNota2.Text);
            nota3 = Convert.ToDouble(textBoxNota3.Text);
            double suma = nota1 + nota2 + nota3;
            MessageBox.Show("La suma de las tres notas es: " + suma);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al sumar las notas: " + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Se ha inicializado el formulario.");
        }
    }
}
