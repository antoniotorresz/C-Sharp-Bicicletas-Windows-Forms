using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBicicletas2019
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
            btnAgregar.DialogResult = DialogResult.OK;
            ListarActivos();
        }

        public string id;
        public string nombre;
        public string precioVenta;

        private void ListarActivos()
        {
            dataGridView1.DataSource = ControladorProducto.ListarProductosActivos();
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dataGridView1.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dataGridView1.CurrentRow);
        }

        private void LlenarFormulario(DataGridViewRow currentRow)
        {
            try
            {

                id = Convert.ToString(currentRow.Cells["idProducto"].Value);
                nombre = Convert.ToString(currentRow.Cells["nombre"].Value);
                precioVenta = Convert.ToString(currentRow.Cells["precioVenta"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            ListarActivos();
        }


        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dataGridView1.CurrentRow);
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
