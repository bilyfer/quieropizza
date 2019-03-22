using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ReporteVentasPorProductoBL
    {
        Contexto _contexto;
        public List<ReporteVentasPorProducto> ListaReporteVentasPorProducto { get; set; }

        public ReporteVentasPorProductoBL()
        {
            _contexto = new Contexto();
            ListaReporteVentasPorProducto = new List<ReporteVentasPorProducto>();
        }

        public List<ReporteVentasPorProducto> ObtenerVentasPorProducto()
        {
            ListaReporteVentasPorProducto = _contexto.OrdenDetalle
                .Include("Producto")
                .Where(r => r.Orden.Activo == true)
                .GroupBy(g => g.Producto.Descripcion)
                .Select(s => new ReporteVentasPorProducto()
                {
                    Producto = s.Key,
                    Cantidad = s.Sum(r => r.Cantidad),
                    Total = s.Sum(r => r.Total)
                }).ToList();

            return ListaReporteVentasPorProducto;
        }
    }
}
