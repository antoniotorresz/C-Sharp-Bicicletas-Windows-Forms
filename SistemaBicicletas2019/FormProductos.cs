using Controlador;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class FormProductos : Form
    {
        private string filePath, imagenB64;

        public FormProductos()
        {
            InitializeComponent();
        }
        private void ListarActivos() {
            dgvProductoAct.DataSource = ControladorProducto.ListarProductosActivos();
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dgvProductoAct.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductoAct.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductoAct.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductoAct.AllowUserToResizeColumns = false;
            dgvProductoAct.AllowUserToResizeRows = false;
        }
        private void ListarInactivos()
        {
            dvgProductoInact.DataSource = ControladorProducto.ListarProductosInactivos();

            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dvgProductoInact.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgProductoInact.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dvgProductoInact.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductoInact.AllowUserToResizeColumns = false;
            dvgProductoInact.AllowUserToResizeRows = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.ListarActivos();
            this.ListarInactivos();
        }

        private void BunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagen PNG|*.png |Imagen JPG|*.jpg";
           if( dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = dialog.FileName;
                //MessageBox.Show(filePath);
                lblfile.Text = filePath;
            }
        }

        private void DgvProductoAct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dgvProductoAct.CurrentRow);
        }

        private void DgvProductoAct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dgvProductoAct.CurrentRow);
        }

        private void DgvProductoAct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dgvProductoAct.CurrentRow);
        }

        private void DgvProductoAct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dgvProductoAct.CurrentRow);
        }

        private void DgvProductoAct_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dgvProductoAct.CurrentRow);
        }

        private void LlenarFormulario(DataGridViewRow currentRow)
        {
            try
            {
                if (!string.IsNullOrEmpty(Convert.ToString(currentRow.Cells["foto"].Value)))
                {
                    var pic = Convert.FromBase64String(Convert.ToString(currentRow.Cells["foto"].Value));
                    imagenB64 = Convert.ToString(currentRow.Cells["foto"].Value);
                    using (MemoryStream ms = new MemoryStream(pic))
                    {
                        pictureBoxProducto.Image = Image.FromStream(ms);
                    }

                }
                else
                {
                    pictureBoxProducto.Image = SistemaBicicletas2019.Properties.Resources.bicycle__1_;
                }

                TextBox_IdProducto.Text = Convert.ToString(currentRow.Cells["idProducto"].Value);
                TextBox_NombreProducto.Text = Convert.ToString(currentRow.Cells["nombre"].Value);
                TextBox_DescripcionProducto.Text = Convert.ToString(currentRow.Cells["descripcion"].Value);
                TextBox_PrecioProducto.Text = Convert.ToString(currentRow.Cells["precioVenta"].Value);
                TextBox_CantidadProducto.Text = Convert.ToString(currentRow.Cells["cantidad"].Value);
                lblfile.Text = Convert.ToString(currentRow.Cells["rutaFoto"].Value);

                imagenB64 = Convert.ToString(currentRow.Cells["foto"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Buscar()
        {
            try
            {
                string key = TextBox_Buscar.Text;

                dgvProductoAct.DataSource = ControladorProducto.Buscar(key);

                //Estas lineas son para ajustar el data grid al tamaño del contenedor
                dgvProductoAct.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvProductoAct.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvProductoAct.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvProductoAct.AllowUserToResizeColumns = false;
                dgvProductoAct.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvProductoAct_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void DgvProductoAct_MouseUp(object sender, MouseEventArgs e)
        {
            LlenarFormulario(dgvProductoAct.CurrentRow);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string respuesta = ControladorProducto.ActivarProducto(TextBox_IdProducto.Text);
            MessageBox.Show(respuesta);
            this.ListarActivos();
            this.ListarInactivos();
        }

        private void DvgProductoInact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarFormulario(dvgProductoInact.CurrentRow);
        }

        private void DvgProductoInact_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dvgProductoInact.CurrentRow);
        }

        private void DvgProductoInact_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenarFormulario(dvgProductoInact.CurrentRow);
        }

        private void DvgProductoInact_MouseDown(object sender, MouseEventArgs e)
        {
            LlenarFormulario(dvgProductoInact.CurrentRow);
        }

        private void DvgProductoInact_MouseUp(object sender, MouseEventArgs e)
        {
            LlenarFormulario(dvgProductoInact.CurrentRow);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string resultado = ControladorProducto.DesactivarProducto(TextBox_IdProducto.Text);
            MessageBox.Show(resultado);
            this.ListarActivos();
            this.ListarInactivos();
        }

        private void TextBox_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string resultado = "";
            if (! string.IsNullOrEmpty(filePath))
            {
                imagenB64 = ControladorProducto.CodificarB64(filePath);
            }

            if (Convert.ToInt32(TextBox_CantidadProducto.Text) > 0)
            {
                if (string.IsNullOrEmpty(TextBox_IdProducto.Text))
                {
                    /*
                     string nombre, string descripcion, 
                string precioVenta, string cantidad, string rutafoto, string foto
                     */
                    resultado = ControladorProducto.InsertarProducto(TextBox_NombreProducto.Text,
                        TextBox_DescripcionProducto.Text, TextBox_PrecioProducto.Text, TextBox_CantidadProducto.Text,
                        filePath, imagenB64);
                    MessageBox.Show(resultado);
                    this.ListarActivos();
                    this.ListarInactivos();
                }
                else
                {
                    resultado = ControladorProducto.ActualizarProducto(TextBox_IdProducto.Text, TextBox_NombreProducto.Text,
                        TextBox_DescripcionProducto.Text, TextBox_PrecioProducto.Text, TextBox_CantidadProducto.Text,
                        lblfile.Text, imagenB64);
                    MessageBox.Show(resultado);
                }
            }
            else {
                MessageBox.Show("¡NO INGRESE CANTIDADES NEGATIVAS!");
            }
            
            

            this.ListarActivos();
            this.ListarInactivos();
        }
    }
}
