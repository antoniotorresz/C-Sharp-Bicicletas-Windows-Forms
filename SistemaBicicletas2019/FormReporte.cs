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
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaBicicletas2019
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
            ListarReportes();
            ChartReporte();
            ListarVentaMes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int mes = (comboBox1.SelectedIndex) + 1;
                ListarReportesVenta(mes);
            }
        }


        private void ListarReportes()
        {
            dataGridView1.DataSource = ControladorReporte.ListarProductosReporte();
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

        private void ListarReportesVenta(int mes)
        {
            dataGridView2.DataSource = ControladorReporte.ReporteVentaMes(mes);
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dataGridView2.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void ListarVentaMes()
        {
            dataGridView2.DataSource = ControladorReporte.ListaVentaMes();
            //Estas lineas son para ajustar el data grid al tamaño del contenedor
            dataGridView2.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void ChartReporte()
        {
            try
            {
                DataRow dr;
                DataTable dt = ControladorReporte.ListarProductosReporte();
                chart1.Titles.Add("Número de ventas donde aparece el producto");
                chart1.Series.Clear();

                if (dt.Rows.Count > 0)
                {
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        Series series = chart1.Series.Add(dr.ItemArray[0].ToString());
                        series.Points.Add(Convert.ToDouble(dr.ItemArray[1].ToString()));
                        System.Diagnostics.Debug.WriteLine(i);
                    }

                }
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);

            }
        }

    }
}
