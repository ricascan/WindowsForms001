using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms001.DataSet1TableAdapters;

namespace WindowsForms001
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.dataSet1.Facturas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Lineas_factura' Puede moverla o quitarla según sea necesario.
            this.lineas_facturaTableAdapter.Fill(this.dataSet1.Lineas_factura);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.Fill(dataSet1, "facturas");



            //dataGridView1.DataSource = dataSet1;
            //dataGridView1.DataMember = "Facturas";





            /*dataGridView2.DataSource = facturasBindingSource;
            dataGridView2.DataMember = "Lineas_factura";*/
        }

        private static String Conexion()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            return settings.ConnectionString;
        }
    }
}
