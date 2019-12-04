using Controlador;
using System;
using System.Windows.Forms;

namespace SistemaBicicletas2019
{
    public partial class FormProvedores : Form
    {
        public FormProvedores()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //cargamos los datos desde el data table que retornamos en el controlador
                dataGridViewProvedores.DataSource = ControladorProvedor.Listar();

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dataGridViewProvedores.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dataGridViewProvedores.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridViewProvedores.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewProvedores.AllowUserToResizeColumns = false;
                dataGridViewProvedores.AllowUserToResizeRows = false;

                lbltotal.Text = "Numero de proveedores: " + dataGridViewProvedores.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void FormProvedores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void limpiarDatos()
        {
            TextBox_IdProvedor.Text = "";
            TextBox_NombreProvedor.Text = "";
            TextBox_DireccionProvedor.Text = "";
            TextBox_TelefonoProvedor.Text = "";
            TextBox_CorreoProvedor.Text = "";
        }

        private void DataGridViewProvedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            llenarFormulario(dataGridViewProvedores.CurrentRow);
        }

        private void llenarFormulario(DataGridViewRow currentRow)
        {
            TextBox_IdProvedor.Text = Convert.ToString(currentRow.Cells["id"].Value);
            TextBox_NombreProvedor.Text = Convert.ToString(currentRow.Cells["nombre"].Value);
            TextBox_DireccionProvedor.Text = Convert.ToString(currentRow.Cells["direccion"].Value);
            TextBox_TelefonoProvedor.Text = Convert.ToString(currentRow.Cells["tel"].Value);
            TextBox_CorreoProvedor.Text = Convert.ToString(currentRow.Cells["email"].Value);

        }

        private void DataGridViewProvedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarFormulario(dataGridViewProvedores.CurrentRow);

        }

        private void DataGridViewProvedores_KeyDown(object sender, KeyEventArgs e)
        {
            llenarFormulario(dataGridViewProvedores.CurrentRow);

        }

        private void DataGridViewProvedores_KeyUp(object sender, KeyEventArgs e)
        {
            llenarFormulario(dataGridViewProvedores.CurrentRow);

        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (TextBox_IdProvedor.Text == string.Empty) {
                    if (TextBox_NombreProvedor.Text == string.Empty)
                    {
                        MessageBox.Show("Llene los campos");
                    }
                    else
                    {
                        respuesta = ControladorProvedor.Insertar(TextBox_NombreProvedor.Text.Trim(),
                            TextBox_DireccionProvedor.Text.Trim(), TextBox_TelefonoProvedor.Text.Trim(),
                            TextBox_CorreoProvedor.Text.Trim());
                        MessageBox.Show(respuesta);
                        limpiarDatos();
                        this.Listar();
                    }
                }
                else{
                    respuesta = ControladorProvedor.Actualizar(TextBox_IdProvedor.Text.Trim() ,TextBox_NombreProvedor.Text.Trim(),
                            TextBox_DireccionProvedor.Text.Trim(), TextBox_TelefonoProvedor.Text.Trim(),
                            TextBox_CorreoProvedor.Text.Trim());
                    limpiarDatos();
                    this.Listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (TextBox_IdProvedor.Text == string.Empty)
                {
                    MessageBox.Show("Id vacío");
                }
                else
                {
                    respuesta = ControladorProvedor.Eliminar(TextBox_IdProvedor.Text.Trim());
                    limpiarDatos();
                    this.Listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                

                dataGridViewProvedores.DataSource = ControladorProvedor.Buscar(TextBox_Buscar.Text);

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dataGridViewProvedores.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dataGridViewProvedores.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridViewProvedores.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewProvedores.AllowUserToResizeColumns = false;
                dataGridViewProvedores.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}

