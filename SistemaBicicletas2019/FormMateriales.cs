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
    public partial class FormMateriales : Form
    {
        public FormMateriales()
        {
            InitializeComponent();
        }

        private void ListarActivos()
        {
            try
            {
                //cargamos los datos desde el data table que retornamos en el controlador
                dgvMaterialesAct.DataSource = ControladorMaterial.ListarActivos();

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dgvMaterialesAct.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvMaterialesAct.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvMaterialesAct.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMaterialesAct.AllowUserToResizeColumns = false;
                dgvMaterialesAct.AllowUserToResizeRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void ListarInactivos()
        {
            try
            {
                //cargamos los datos desde el data table que retornamos en el controlador
                dgvMaterialesInac.DataSource = ControladorMaterial.ListarInactivos();

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dgvMaterialesInac.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvMaterialesInac.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvMaterialesInac.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMaterialesInac.AllowUserToResizeColumns = false;
                dgvMaterialesInac.AllowUserToResizeRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                string key = TextBox_Buscar.Text;

                dgvMaterialesAct.DataSource = ControladorMaterial.BuscarMaterial(key);

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dgvMaterialesAct.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvMaterialesAct.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvMaterialesAct.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMaterialesAct.AllowUserToResizeColumns = false;
                dgvMaterialesAct.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LlenarCombo() {

            DataTable dt = ControladorMaterial.ListarNombreProvedor();

            for (int i = 0; i < dt.Rows.Count; i++) {
                comboBox_NombreProvedor.Items.Add(dt.Rows[i]["idProvedor"]);
            }
        }

        private void FormMateriales_Load(object sender, EventArgs e)
        {
            this.ListarActivos();
            this.ListarInactivos();
            this.LlenarCombo();
            comboBox_NombreProvedor.Text = "Seleccione nombre provedor";
        }

        private void DgvMaterialesAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarFormulario(dgvMaterialesAct.CurrentRow);
        }

        private void DgvMaterialesAct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dgvMaterialesAct.CurrentRow);
        }

        private void llenarFormulario(DataGridViewRow CurrentRow)
        {
            try
            {
                TextBox_IdMaterial.Text = Convert.ToString(CurrentRow.Cells["idMaterial"].Value);
                TextBox_NombreMaterial.Text = Convert.ToString(CurrentRow.Cells["nombre"].Value);
                TextBox_DescripcionMaterial.Text = Convert.ToString(CurrentRow.Cells["descripcion"].Value);
                TextBox_PrecioCompraMaterial.Text = Convert.ToString(CurrentRow.Cells["precioCompra"].Value);
                TextBox_CantidadMateriales.Text = Convert.ToString(CurrentRow.Cells["cantidad"].Value);
                comboBox_NombreProvedor.Text = Convert.ToString(CurrentRow.Cells["idProvedor"].Value);
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        private void DgvMaterialesAct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dgvMaterialesAct.CurrentRow);
        }

        private void DgvMaterialesAct_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dgvMaterialesAct.CurrentRow);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            /*
             string nombre, string descripcion, 
                                              string cantidad, string precioCompra, string nombreProvedor
             */

            string respuesta = "";
            if (TextBox_IdMaterial.Text == string.Empty)
            {
                respuesta = ControladorMaterial.InsertarMaterial(TextBox_NombreMaterial.Text, TextBox_DescripcionMaterial.Text,
                TextBox_CantidadMateriales.Text, TextBox_PrecioCompraMaterial.Text, comboBox_NombreProvedor.Text);
            }
            else
            {
                respuesta = ControladorMaterial.ActualizarMaterial(TextBox_IdMaterial.Text,TextBox_NombreMaterial.Text, TextBox_DescripcionMaterial.Text,
                TextBox_CantidadMateriales.Text, TextBox_PrecioCompraMaterial.Text, comboBox_NombreProvedor.Text);
            }

            MessageBox.Show(respuesta);
            this.ListarActivos();
            this.ListarInactivos();
        }

        private void DgvMaterialesInac_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dgvMaterialesInac.CurrentRow);
        }

        private void DgvMaterialesInac_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            llenarFormulario(dgvMaterialesInac.CurrentRow);
        }

        private void DgvMaterialesInac_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dgvMaterialesAct.CurrentRow);
        }

        private void DgvMaterialesInac_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dgvMaterialesAct.CurrentRow);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string respuesta = ControladorMaterial.DesactivarMaterial(TextBox_IdMaterial.Text);
            MessageBox.Show(respuesta);
            this.ListarActivos();
            this.ListarInactivos();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string respuesta = ControladorMaterial.ActivarMaterial(TextBox_IdMaterial.Text);
            MessageBox.Show(respuesta);
            this.ListarActivos();
            this.ListarInactivos();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Btn_OnClick");
            this.Buscar();
        }

        private void TextBox_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvMaterialesAct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
