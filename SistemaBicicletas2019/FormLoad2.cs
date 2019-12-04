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
    public partial class FormLoad2 : Form
    {
        public FormLoad2()
        {
            InitializeComponent();
            btnAgregar.DialogResult = DialogResult.OK;
        }

        public string id;
        public string nombre;
        public string precio;

        private void FormLoad2_Load(object sender, EventArgs e)
        {
            ListComboProvedor();
        }

        private void ListarActivos(string id)
        {
            dataGridView1.DataSource = ControladorOrden.listMaterialProvedor(id);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void LlenarFormulario(DataGridViewRow currentRow)
        {
            try
            {
                id = Convert.ToString(currentRow.Cells[0].Value);
                nombre = Convert.ToString(currentRow.Cells[1].Value);
                precio = Convert.ToString(currentRow.Cells[4].Value);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dataGridView1.CurrentRow);
        }

        public void ListComboProvedor()
        {
            this.comboProvedor.DataSource = ControladorOrden.ComboProvedor(); ;
            this.comboProvedor.DisplayMember = "NombreProvedor";
            this.comboProvedor.ValueMember = "IdProvedor";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProvedor.SelectedItem != null)
            {
                string provedor = comboProvedor.SelectedValue.ToString();
                ListarActivos(provedor);
            }
        }
    }
}
