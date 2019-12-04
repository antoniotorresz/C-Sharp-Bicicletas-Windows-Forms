using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class FormMain : Form
    {
        private List<string> imagenes = ControladorProducto.ObtenerImagenes();

        private int i;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cargarSlider(int i)
        {
            var pic = Convert.FromBase64String(imagenes[i]);
            using (MemoryStream ms = new MemoryStream(pic))
            {
                pbSlider.Image = Image.FromStream(ms);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (i < imagenes.Count)
            {
                cargarSlider(i);
                i++;
            }
            else {
                i = 0;
                cargarSlider(i);
            }
        }

        private void PbSlider_Click(object sender, EventArgs e)
        {

        }
    }
}
