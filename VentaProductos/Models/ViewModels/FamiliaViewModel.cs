using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaProductos.Models.ViewModels
{
    public class FamiliaViewModel
    {
        public int IDFamilia { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Familia")]
        public string NombreFamilia { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Usuario Ingreso")]
        public string UsuarioIngreso { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public int Estado { get; set; }
        
    }
}