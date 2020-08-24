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
    public partial class Form6 : Form
    {
        DataSet _dataSet;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            _dataSet = new DataSet();
            DataTable tabla = new DataTable("tabla1");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            DataRow fila = tabla.NewRow();
            fila["Nombre"] = "Pedro";
            fila["Apellidos"] = "Álvarez";
            tabla.Rows.Add(fila);

            DataTable tabla2 = new DataTable("tabla2");
            tabla2.Columns.Add("Numero");
            tabla2.Columns.Add("Concepto");
            DataRow fila2 = tabla2.NewRow();
            fila2["Numero"] = "1";
            fila2["Concepto"] = "Ordenador";
            tabla2.Rows.Add(fila2);

            _dataSet.Tables.Add(tabla2);
            dataGridView1.DataSource = _dataSet;
            dataGridView1.DataMember = "tabla2";
        }
    }
}
