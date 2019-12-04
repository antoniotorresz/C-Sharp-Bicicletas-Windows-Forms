using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorReporte
    {
        public static DataTable ListarProductosReporte()
        {
            DReporte datos = new DReporte();
            return datos.ListarReporteProducto();
        }

        public static DataTable ChartProductosReporte()
        {
            DReporte datos = new DReporte();
            return datos.ChartReporteProducto();
        }

        public static DataTable ReporteVentaMes(int mes)
        {
            DReporte datos = new DReporte();
            return datos.ReporteVenta(mes);
        }

        public static DataTable ListaVentaMes()
        {
            DReporte datos = new DReporte();
            return datos.ReporteVentaMes();
        }
    }
}