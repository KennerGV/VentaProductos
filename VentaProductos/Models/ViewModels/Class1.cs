using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaProductos.Models.ViewModels
{
    public class Class1
    {
        

        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal SaldoInventario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string UsuarioIngreso { get; set; }
        public int IDFamilia { get; set; }

    }
}