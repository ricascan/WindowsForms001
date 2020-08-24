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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            ActualizarTabla();

        }

        private void ActualizarTabla()
        {
            using (SqlConnection connection = new SqlConnection(Conexion()))
            {
                connection.Open();
                String sql = "select * from facturas";
                SqlCommand command = new SqlCommand(sql, connection);
                DataTable table = new DataTable();
                SqlDataReader lector = command.ExecuteReader();
                table.Load(lector);
                dataGridView1.DataSource = table;
            }
        }

        private static String Conexion()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            return settings.ConnectionString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text != "" && textBoxConcepto.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(Conexion()))
                {
                    connection.Open();
                    String sql = "insert into facturas(numero, concepto) values(@numero, @concepto)";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@numero", textBoxNumero.Text);
                    command.Parameters.AddWithValue("@concepto", textBoxConcepto.Text);
                    command.ExecuteNonQuery();
                    textBoxNumero.Text = "";
                    textBoxConcepto.Text = "";
                    ActualizarTabla();
                }
            }
        }
    }
}
