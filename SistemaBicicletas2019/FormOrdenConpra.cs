using Controlador;
using System;
using System.Windows.Forms;

namespace SistemaBicicletas2019
{
    public partial class FormOrdenConpra : Form
    {

        string datos = "";
        string provedor = "";

        public FormOrdenConpra()
        {
            InitializeComponent();
            ListComboProvedor();
        }

        public void calcularTotal()
        {
            float total = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                float importe = float.Parse(dr.Cells[6].Value.ToString());
                total += importe;
            };
            Total.Text = total.ToString();

        }

        public void ListComboProvedor()
        {
            this.comboBox1.DataSource = ControladorOrden.ComboProvedor(); ;
            this.comboBox1.DisplayMember = "NombreProvedor";
            this.comboBox1.ValueMember = "IdProvedor";
        }

        private void ListarActivos(string id)
        {
            dataGridView1.DataSource = ControladorOrden.listMaterialComprados(id);
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dataGridView1.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void BtnNuevaVenta_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(TextBox_Fecha.Text);
            datos = ControladorOrden.InsertarOrden(fecha, provedor);
            MessageBox.Show(datos);
            string[] respuesta = datos.Split(',');

            TextBox_IdOrdenCompra.Text = respuesta[0].ToString();
            TextBox_Factura.Text = respuesta[1].ToString();
            bunifuCards1.Visible = true;
        }

        private void FormOrdenConpra_Load_1(object sender, EventArgs e)
        {
            TextBox_Fecha.Text = "" + DateTime.Now.Date;
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                provedor = comboBox1.SelectedValue.ToString();
            }
        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            FormLoad2 fl = new FormLoad2();
            DialogResult res = fl.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal
            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                Textbox_Id.Text = fl.id; //asignamos al texbox el dato de la variable
                TextBox_Material.Text = fl.nombre;
                Textbox_Precio.Text = fl.precio;

            }
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string id = TextBox_IdOrdenCompra.Text;
            string idM = Textbox_Id.Text;
            string cant = Textbox_Cantidad.Text;
            try
            {
                if (string.IsNullOrEmpty(Textbox_Cantidad.Text) || Convert.ToInt32(cant) < 1)
                {
                    ListarActivos(id);
                }
                else
                {
                    string res = ControladorOrden.InsertarOrden(id, idM, cant);
                    MessageBox.Show(res);
                    ListarActivos(id);
                }
                calcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string message = ControladorOrden.ActualizarPagado(TextBox_IdOrdenCompra.Text,
                Total.Text);
            MessageBox.Show(message);
            LimpiarCampos();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string message = ControladorOrden.CancelarOrden(TextBox_IdOrdenCompra.Text);
            MessageBox.Show("Cancelado");

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TextBox_IdOrdenCompra.Text = "";
            TextBox_Factura.Text = "";
            comboBox1.Text = "";
            bunifuCards1.Visible = false;
        }
    }
}
