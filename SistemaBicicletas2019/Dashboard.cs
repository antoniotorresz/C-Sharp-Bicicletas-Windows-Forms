using Controlador;
using SistemaBicicletas2019;
using System;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class SmartBikes : Form
    {
        public int IdUsuario;
        public string NombreUsuario;
        public string Rol;

        public SmartBikes(int idUsuario, string username, string rol)
        {
            InitializeComponent();
            
            nav(new FormMain(), contentMain);

            int actualRol;
            if (rol.Equals("Empleado"))
            {

                actualRol = ControladorUsuario.validarPuesto(idUsuario);

                mostrarOpciones(actualRol);
            }
            else if (rol.Equals("Cliente"))
            {
                MessageBox.Show("Bienvenido cliente!");
            }
            IdUsuario = idUsuario;
            NombreUsuario = username;
            Rol = rol;

            cargarDatos();
        }

        private void mostrarOpciones(int rolE)
        {
            try
            {
               
                if (rolE == 1) {
                    MessageBox.Show("Bienvenido Administrador!");
                    this.bunifuFlatButton2.Enabled = true;
                    this.bunifuFlatButton3.Enabled = true;
                    this.bunifuFlatButton4.Enabled = true;
                    this.bunifuFlatButton5.Enabled = true;
                    this.bunifuFlatButton6.Enabled = true;
                    this.bunifuFlatButton7.Enabled = true;
                    this.bunifuFlatButton8.Enabled = true;
                    this.bunifuFlatButton9.Enabled = true;


                }
                else if (rolE == 2) {
                    MessageBox.Show("Bienvenido Vendedor!");
                    this.bunifuFlatButton3.Enabled = true;

                } else if (rolE == 3)
                {
                    MessageBox.Show("Bienvenido almacenista!");
                    this.bunifuFlatButton4.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        private void cargarDatos()
        {
            //MessageBox.Show("Bienvenido(a) de nuevo " + NombreUsuario);
            lblusername.Text = NombreUsuario;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 80;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }
        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            nav(formMain, contentMain);
        }

        public void nav(Form form, Panel panel)
        {

            form.TopLevel = false;
            form.Size = panel.Size; // para un tamaño respopnsivo
            form.Dock = DockStyle.Fill; // para un tamaño respopnsivo
            form.AutoScroll = true; //Aqui activamos el scroll del panel
            form.FormBorderStyle = FormBorderStyle.None; //Quitamos el borde del form 
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Sidebar.Width = 270;
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form formProducto = new FormProductos();
            nav(formProducto, contentMain);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            nav(formVentas, contentMain);
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            FormMateriales fm = new FormMateriales();
            nav(fm, contentMain);
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            nav(formClientes, contentMain);
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            FormProvedores formProvedores = new FormProvedores();
            nav(formProvedores, contentMain);
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            nav(formEmpleados, contentMain);
        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {
            FormOrdenConpra form = new FormOrdenConpra();
            nav(form, contentMain);
        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            nav(formReporte, contentMain);
        }
    }
}
