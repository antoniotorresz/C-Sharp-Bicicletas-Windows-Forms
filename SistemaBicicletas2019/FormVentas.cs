using Controlador;
using SistemaBicicletas2019;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class FormVentas : Form
    {
        string id_venta = "";
        public FormVentas()
        {
            InitializeComponent();

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + DateTime.Now;
            this.LlenarCombo();
        }

        private void LlenarCombo()
        {

            DataTable dt = ControladorVenta.LlenarComboEmpleado();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["idEmpleado"]);
            }
        }

        private void nombreEmple_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ListarActivos(string id)
        {
            dataGridView1.DataSource = ControladorVenta.ListarVentaProducto(id);
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

        public void calcularTotal()
        {
            float total = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                float importe = float.Parse(dr.Cells[5].Value.ToString());
                total += importe;
            };
            
            Total.Text = total.ToString();

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int posiscion = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                menu.Items.Add("eliminar", null, (s, ex) => eliminarProductoVenta(dataGridView1.CurrentRow)).Name = "Eliminar";
                menu.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        public void eliminarProductoVenta(DataGridViewRow currentRow)
        {
            string idV = currentRow.Cells["idVenta"].Value.ToString();
            string idP = currentRow.Cells["idProducto"].Value.ToString();
            string cant = currentRow.Cells["Cantidad"].Value.ToString();
            string res = ControladorVenta.EliminarVentaProducto(idV, idP, cant);
            MessageBox.Show(res);
            ListarActivos(label10.Text);
        }

        private void BunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNuevaVenta_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))

            {
                DateTime fecha = DateTime.Parse(textBox1.Text);
                string idE = comboBox1.Text;
                id_venta = ControladorVenta.InsertarVenta(fecha, idE);
                MessageBox.Show(idE);
                label10.Text = id_venta;
                bunifuCards1.Visible = true;
            }
            else {
                MessageBox.Show("Ingrese el id del empleado");
            }
            
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string id = id_venta;
            string idp = Textbox_Id.Text;
            string cant = Textbox_Cantidad.Text;
            try
            {
                if (string.IsNullOrEmpty(Textbox_Cantidad.Text) || Convert.ToInt32(Textbox_Cantidad.Text) < 1)
                {
                    ListarActivos(label10.Text);
                }
                else
                {
                    string res = ControladorVenta.InsertarVentaProducto(id, idp, cant);
                    MessageBox.Show(res);
                    ListarActivos(label10.Text);
                }
                calcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormLoad fl = new FormLoad();
            DialogResult res = fl.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal
            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                Textbox_Id.Text = fl.id; //asignamos al texbox el dato de la variable
                TextBox_NombreProducto.Text = fl.nombre;
                Textbox_PrecioVenta.Text = fl.precioVenta;

            }
        }

        private void BunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            string respuesta = ControladorVenta.updateVenta(label10.Text, Total.Text);
            MessageBox.Show(respuesta);
            FormVentas formVentas = new FormVentas();
            limpiarForm();
        }

        private void limpiarForm()
        {
            comboBox1.Text = "";
            Textbox_Id.Text = "";
            TextBox_NombreProducto.Text = "";
            Textbox_PrecioVenta.Text = "";
            Textbox_Cantidad.Text = "";
            Total.Text = "";
            bunifuCards1.Visible = false;
        }
    }
}
