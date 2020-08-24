﻿using System;
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
    public partial class Form4 : Form
    {

        IList<Persona> lista = new List<Persona>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            IPersonasRepository personasRepository = new PersonaRepositoryMemoria();
            lista = personasRepository.BuscarTodos();


            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "edad";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
