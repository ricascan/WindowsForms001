using Semicrol.Cursos.Persistencia;
using Semicrol.Cursos.PersistenciaADO;
using Semicrol.Cursos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms001
{
    public partial class Form12 : Form
    {
        

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {                      
            IFacturaRepository facturaRepository = new FacturaRepository();
            ILineaFacturaRepository lineaFacturaRepository = new LineaFacturaRepository();
            IServicioFacturacion servicio = new ServicioFacturacion(facturaRepository, lineaFacturaRepository);

            bindingSource1.DataSource = servicio.BuscarFacturas();
            
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Concepto = '" + textBoxFiltro.Text + "'";
        }
    }
}
