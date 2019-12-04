using Controlador;
using System;
using System.Windows.Forms;

namespace SistemaBicicletas2019
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }
        private void ListarActivos()
        {
            dgvEmpleados.DataSource = ControladorEmpleado.ListarEmpleadosAct();
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dgvEmpleados.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEmpleados.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.AllowUserToResizeRows = false;
        }

        private void LlenarFormulario(DataGridViewRow currentRow)
        {
            try
            {
                
                int idPuesto = Convert.ToInt32(currentRow.Cells["puesto"].Value);
                string puesto = "";
               
                if (idPuesto == 1)
                {
                    puesto = "Administrador";
                }
                else if (idPuesto == 2)
                {
                    puesto = "Vendedor";
                }
                else if (idPuesto == 3)
                {
                    puesto = "Almacenista";
                }
                else {
                    puesto = "" + idPuesto;
                }
                
                TextBox_IdEmp.Text = Convert.ToString(currentRow.Cells["idEmpleado"].Value);
                cmb_EmpleadoPuesto.Text = puesto;

                Textbox_PersonaId.Text = Convert.ToString(currentRow.Cells["idPersona"].Value);
                Textbox_PersonaNombre.Text = Convert.ToString(currentRow.Cells["nombre"].Value);
                Textbox_PersonaApellidoPaterno.Text = Convert.ToString(currentRow.Cells["aPaterno"].Value);
                Textbox_PersonaApellidoMaterno.Text = Convert.ToString(currentRow.Cells["aMaterno"].Value);
                Textbox_PersonaDireccion.Text = Convert.ToString(currentRow.Cells["direcion"].Value);
                Textbox_PersonaTelefono.Text = Convert.ToString(currentRow.Cells["telefono"].Value);
                Textbox_PersonaCorreo.Text = Convert.ToString(currentRow.Cells["correo"].Value);

                comboBox_GeneroPersona.Text = Convert.ToString(currentRow.Cells["genero"].Value);
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

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            int puesto = ControladorEmpleado.ObtenerPuesto(cmb_EmpleadoPuesto.Text);
            char genero = ControladorEmpleado.ObtenerGenero(comboBox_GeneroPersona.Text);

            if (string.IsNullOrEmpty(TextBox_IdEmp.Text))
            {
                respuesta = ControladorEmpleado.InsertarEmpleado(
                    puesto,
                    Textbox_PersonaNombre.Text, Textbox_PersonaApellidoPaterno.Text, Textbox_PersonaApellidoMaterno.Text,
                    genero, Textbox_PersonaDireccion.Text, Textbox_PersonaTelefono.Text, Textbox_PersonaCorreo.Text,
                    Textbox_UsernameUsuario.Text, Textbox_PwdUsuario.Text
                    );
            }
            else {
                    respuesta = ControladorEmpleado.ActualizarEmpleado(
                    TextBox_IdEmp.Text, puesto,
                    Textbox_PersonaId.Text, Textbox_PersonaNombre.Text, Textbox_PersonaApellidoPaterno.Text, Textbox_PersonaApellidoMaterno.Text,
                    genero, Textbox_PersonaDireccion.Text, Textbox_PersonaTelefono.Text, Textbox_PersonaCorreo.Text,
                    Textbox_UsuarioId.Text, Textbox_UsernameUsuario.Text, Textbox_PwdUsuario.Text
                    );
            }

            MessageBox.Show(respuesta);
            this.LimpiarCampos();
            this.ListarActivos();
        }

        private void Buscar()
        {
            try
            {
                string key = TextBox_Buscar.Text;

                dgvEmpleados.DataSource = ControladorEmpleado.Buscar(key);

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dgvEmpleados.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvEmpleados.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvEmpleados.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmpleados.AllowUserToResizeColumns = false;
                dgvEmpleados.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            TextBox_IdEmp.Text = "";


            Textbox_PersonaId.Text = "";
            Textbox_PersonaNombre.Text = "";
            Textbox_PersonaApellidoPaterno.Text = "";
            Textbox_PersonaApellidoMaterno.Text = "";
            Textbox_PersonaDireccion.Text = "";
            Textbox_PersonaTelefono.Text = "";
            Textbox_PersonaCorreo.Text = "";

            /*validar ->*/

            comboBox_GeneroPersona.Text = "";

            Textbox_UsuarioId.Text = "";
            Textbox_UsernameUsuario.Text = "";
            Textbox_PwdUsuario.Text = "";

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            this.ListarActivos();
            SetMaximumLength(Textbox_PersonaTelefono, 10);
        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dgvEmpleados.CurrentRow);
        }

        private void DgvEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            LlenarFormulario(dgvEmpleados.CurrentRow);
        }

        private void DgvEmpleados_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarFormulario(dgvEmpleados.CurrentRow);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string respuesta = ControladorEmpleado.DesactivarEmpleado(TextBox_IdEmp.Text);
            //MessageBox.Show(respuesta);
            this.ListarActivos();
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
