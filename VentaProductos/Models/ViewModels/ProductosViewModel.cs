using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaProductos.Models.ViewModels
{
    public class ProductosViewModel
    {

        public int CodigoProducto { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }
        [Required]
        [Display(Name = "Saldo Inventario")]
        public decimal SaldoInventario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngreso { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Usuario Ingreso")]
        public string UsuarioIngreso { get; set; }
        public int IDFamilia { get; set; }
        
    }
}