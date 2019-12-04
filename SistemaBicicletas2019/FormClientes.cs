using Controlador;
using System;
using System.Windows.Forms;

namespace SistemaBicicletas2019
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void ListarActivos() {
            dgvClientes.DataSource = ControladorCliente.ListarClientesActivos();
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dgvClientes.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string respuesta = ControladorCliente.DesactivarCliente(TextBox_IdCliente.Text);
            MessageBox.Show(respuesta);
            this.ListarActivos();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.ListarActivos();
            SetMaximumLength(Textbox_PersonaTelefono, 10);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            char genero = ControladorCliente.ObtenerGenero(comboBox_GeneroPersona.Text.Trim());

            if (string.IsNullOrEmpty(TextBox_IdCliente.Text))
            {
                if (Textbox_PersonaCorreo.Text.Contains("@") && Textbox_PersonaCorreo.Text.Contains("."))
                {
                    string respuesta = ControladorCliente.
                    InsertarCliente(Textbox_PersonaNombre.Text, Textbox_PersonaApellidoPaterno.Text,
                    Textbox_PersonaApellidoMaterno.Text, genero, Textbox_PersonaDireccion.Text,
                    Textbox_PersonaTelefono.Text, Textbox_PersonaCorreo.Text, Textbox_UsernameUsuario.Text, Textbox_PwdUsuario.Text);
                    MessageBox.Show(respuesta);
                    this.ListarActivos();
                }
                else
                {
                    MessageBox.Show("Formato incorrecto de correo.");
                }
            }
            else {
                string respuesta = ControladorCliente.
                    ActualizarCliente(Textbox_PersonaId.Text, Textbox_PersonaNombre.Text, Textbox_PersonaApellidoPaterno.Text,
                    Textbox_PersonaApellidoMaterno.Text, genero, Textbox_PersonaDireccion.Text,
                    Textbox_PersonaTelefono.Text, Textbox_PersonaCorreo.Text,
                    TextBox_IdCliente.Text, 
                    Textbox_UsuarioId.Text,Textbox_UsernameUsuario.Text, Textbox_PwdUsuario.Text);
                MessageBox.Show(respuesta);
                this.ListarActivos();
            }
        }

        private void Buscar()
        {
            try
            {
                string key = TextBox_Buscar.Text;

                dgvClientes.DataSource = ControladorCliente.Buscar(key);

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dgvClientes.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvClientes.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvClientes.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvClientes.AllowUserToResizeColumns = false;
                dgvClientes.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dgvClientes.CurrentRow);
        }

        private void DgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dgvClientes.CurrentRow);
        }

        private void DgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            LlenarFormulario(dgvClientes.CurrentRow);
        }

        private void DgvClientes_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarFormulario(dgvClientes.CurrentRow);
        }

        private void LlenarFormulario(DataGridViewRow currentRow)
        {
            try
            {
                
                TextBox_IdCliente.Text = Convert.ToString(currentRow.Cells["idCliente"].Value);

                Textbox_PersonaId.Text = Convert.ToString(currentRow.Cells["idPersona"].Value);
                Textbox_PersonaNombre.Text = Convert.ToString(currentRow.Cells["nombre"].Value);
                Textbox_PersonaApellidoPaterno.Text = Convert.ToString(currentRow.Cells["aPaterno"].Value);
                Textbox_PersonaApellidoMaterno.Text = Convert.ToString(currentRow.Cells["aMaterno"].Value);
                Textbox_PersonaDireccion.Text = Convert.ToString(currentRow.Cells["direcion"].Value);
                Textbox_PersonaTelefono.Text = Convert.ToString(currentRow.Cells["telefono"].Value);
                Textbox_PersonaCorreo.Text = Convert.ToString(currentRow.Cells["correo"].Value);

                /*validar ->*/comboBox_GeneroPersona.Text = Convert.ToString(currentRow.Cells["genero"].Value);

                Textbox_UsuarioId.Text = Convert.ToString(currentRow.Cells["idUsuario"].Value);
                Textbox_UsernameUsuario.Text = Convert.ToString(currentRow.Cells["nombreUsuario"].Value);
                Textbox_PwdUsuario.Text = Convert.ToString(currentRow.Cells["contrasenia"].Value);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Textbox_PwdUsuario_OnValueChanged(object sender, EventArgs e)
        {
            Textbox_PwdUsuario.isPassword = true;
        }

        private void TextBox_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMaterialTextbox materialTextbox, int maximumLength)
        {
            foreach (Control ctl in materialTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;

                    // Set other properties & events here...
                }
            }
        }

        private void Textbox_PersonaTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
