using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaProductos.Models;
using VentaProductos.Models.ViewModels;

namespace VentaProductos.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            List<Class1> lst;
            using (PruebaTEntities db = new PruebaTEntities())
            {
                lst = (from d in db.IN04
                       select new Class1
                       {
                           CodigoProducto = d.CodigoProducto,
                           Descripcion = d.Descripcion,
                           Precio = (decimal)d.Precio,
                           SaldoInventario = (decimal)d.SaldoInventario,
                           FechaIngreso = (DateTime)d.FechaIngreso,
                           
                           

                       }).ToList();
            }

            return View(lst);
        }
        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ProductosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (PruebaTEntities db = new PruebaTEntities())
                    {
                        var oTabla = new IN04();
                        oTabla.Descripcion = model.Descripcion;
                        oTabla.Precio = model.Precio;
                        oTabla.SaldoInventario = model.SaldoInventario;
                        oTabla.FechaIngreso = model.FechaIngreso;
                        oTabla.UsuarioIngreso = model.UsuarioIngreso;

                        db.IN04.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("~/Productos/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}