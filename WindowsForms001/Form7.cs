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

namespace WindowsForms001
{
    public partial class Form7 : Form
    {
        DataSet _dataSet;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            _dataSet = new DataSet();
            
            using (SqlConnection connection = new SqlConnection(Conexion()))
            {
                connection.Open();
                String sql = "select * from facturas";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(_dataSet, "facturas");

                sql = "select * from lineas_factura";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sql, connection);
                adapter2.Fill(_dataSet, "lineas_facturas");

                _dataSet.Relations.Add("relacion", _dataSet.Tables["facturas"].Columns["numero"], _dataSet.Tables["lineas_facturas"].Columns["factura_numero"]);

                dataGridView1.DataSource = _dataSet;
                dataGridView1.DataMember = "facturas";

                dataGridView2.DataSource = _dataSet;
                dataGridView2.DataMember = "lineas_facturas";
            }
        }

        private static String Conexion()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            return settings.ConnectionString;
        }
    }
}
