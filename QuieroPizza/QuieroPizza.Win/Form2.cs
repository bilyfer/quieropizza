using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuieroPizza.Win
{
    public partial class Form2 : Form
    {
        ReporteVentasPorProductoBL _reporteVentasPorProductoBL;

        public Form2()
        {
            InitializeComponent();
            _reporteVentasPorProductoBL = new ReporteVentasPorProductoBL();
            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        void RefrescarDatos()
        {
            var listaReporteVentasPorProducto = _reporteVentasPorProductoBL.ObtenerVentasPorProducto();
            listaReporteVentasPorProductoBindingSource.DataSource = listaReporteVentasPorProducto;
            listaReporteVentasPorProductoBindingSource.ResetBindings(false);
        }
    }
}
