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
    public partial class Form11 : Form
    {
        DataSet _dataSet;
        SqlDataAdapter adapter;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            _dataSet = new DataSet();

            SqlConnection connection = new SqlConnection(Conexion());

            connection.Open();

            String sql = "select * from persona";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            SqlCommand commandInsert = connection.CreateCommand();
            commandInsert.CommandType = CommandType.Text;
            String sqlInsert = "Insert into persona(dni, nombre, apellidos) values (@dni, @nombre, @apellidos)";

            commandInsert.CommandText = sqlInsert;
            commandInsert.Parameters.Add("@dni", SqlDbType.VarChar, 10, "dni");
            commandInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 25, "nombre");
            commandInsert.Parameters.Add("@apellidos", SqlDbType.VarChar, 25, "apellidos");
            commandInsert.Parameters["@dni"].SourceVersion = DataRowVersion.Original;
            SqlCommand commandUpdate = connection.CreateCommand();
            commandUpdate.CommandType = CommandType.Text;
            String sqlUpdate = "Update persona set nombre = @nombre, apellidos = @apellidos where dni = @dni";
            commandUpdate.CommandText = sqlUpdate;
            commandUpdate.Parameters.Add("@dni", SqlDbType.VarChar, 10, "dni");
            commandUpdate.Parameters.Add("@nombre", SqlDbType.VarChar, 25, "nombre");
            commandUpdate.Parameters.Add("@apellidos", SqlDbType.VarChar, 25, "apellidos");
            commandUpdate.Parameters["@dni"].SourceVersion = DataRowVersion.Original;
            SqlCommand commandDelete = connection.CreateCommand();
            commandDelete.CommandType = CommandType.Text;
            String sqlDelete = "Delete from persona where dni = @dni";
            commandDelete.CommandText = sqlDelete;
            commandDelete.Parameters.Add("@dni", SqlDbType.VarChar, 10, "dni");

            commandDelete.Parameters["@dni"].SourceVersion = DataRowVersion.Original;
            adapter = new SqlDataAdapter()
            {
                SelectCommand = command,
                InsertCommand = commandInsert,
                UpdateCommand = commandUpdate,
                DeleteCommand = commandDelete
            };
            adapter.Fill(_dataSet, "persona");



            dataGridView1.DataSource = _dataSet;
            dataGridView1.DataMember = "persona";
        }
        private static String Conexion()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion2"];
            return settings.ConnectionString;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            adapter.Update(_dataSet, "persona");
        }
    }
    
}
