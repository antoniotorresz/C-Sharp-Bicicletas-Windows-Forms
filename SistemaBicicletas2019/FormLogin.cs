using Controlador;
using Design_Dashboard_Modern;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaBicicletas2019
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = ControladorUsuario.IngresarSistema(tb_username.Text.Trim(), tb_password.Text.Trim());
                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "No se pudo ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt32(tabla.Rows[0][4]) == 1)
                    {
                        SmartBikes form = new SmartBikes(Convert.ToInt32(tabla.Rows[0][0]), Convert.ToString(tabla.Rows[0][1]),
                        Convert.ToString(tabla.Rows[0][3]));

                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario "+ tb_username.Text.Trim() + " no está activo", "No se pudo ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace);
            }
        }

        private void Tb_password_OnValueChanged(object sender, EventArgs e)
        {
            tb_password.isPassword = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
