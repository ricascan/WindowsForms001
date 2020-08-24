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
    public partial class Form10 : Form
    {
        DataSet _dataSet;
        SqlDataAdapter adapter;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
            _dataSet = new DataSet();

            SqlConnection connection = new SqlConnection(Conexion());

            connection.Open();

            String sql = "select * from facturas";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            SqlCommand commandInsert = connection.CreateCommand();
            commandInsert.CommandType = CommandType.Text;
            String sqlInsert = "Insert into facturas(numero, concepto) values (@numero, @concepto)";

            commandInsert.CommandText = sqlInsert;
            commandInsert.Parameters.Add("@numero", SqlDbType.Int, 10, "numero");
            commandInsert.Parameters.Add("@concepto", SqlDbType.VarChar, 25, "concepto");
            commandInsert.Parameters["@numero"].SourceVersion = DataRowVersion.Original;
            SqlCommand commandUpdate = connection.CreateCommand();
            commandUpdate.CommandType = CommandType.Text;
            String sqlUpdate = "Update facturas set concepto = @concepto where numero = @numero";
            commandUpdate.CommandText = sqlUpdate;
            commandUpdate.Parameters.Add("@numero", SqlDbType.Int, 10, "numero");
            commandUpdate.Parameters.Add("@concepto", SqlDbType.VarChar, 25, "concepto");
            commandUpdate.Parameters["@numero"].SourceVersion = DataRowVersion.Original;
            SqlCommand commandDelete = connection.CreateCommand();
            commandDelete.CommandType = CommandType.Text;
            String sqlDelete = "Delete from facturas where numero = @numero";
            commandDelete.CommandText = sqlDelete;
            commandDelete.Parameters.Add("@numero", SqlDbType.Int, 10, "numero");

            commandDelete.Parameters["@numero"].SourceVersion = DataRowVersion.Original;
            adapter = new SqlDataAdapter()
            {
                SelectCommand = command,
                InsertCommand = commandInsert,
                UpdateCommand = commandUpdate,
                DeleteCommand = commandDelete
            };
            adapter.Fill(_dataSet, "facturas");
            bindingSource1.DataSource = _dataSet.Tables["facturas"];
            dataGridView1.DataSource = bindingSource1;

            textBoxNumero.DataBindings.Add("Text", bindingSource1, "numero");
            textBoxConcepto.DataBindings.Add("Text", bindingSource1, "concepto");
            

        }
        private static String Conexion()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            return settings.ConnectionString;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(_dataSet, "facturas");
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            bindingSource1.Sort = "Concepto";
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            labelPosition.Text = bindingSource1.Position.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Concepto = '"+textBoxFiltro.Text+"'";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
        }
    }
}
