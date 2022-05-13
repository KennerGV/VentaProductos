using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaProductos.Models;
using VentaProductos.Models.ViewModels;

namespace VentaProductos.Controllers
{
    public class FamiliaController : Controller
    {
        // GET: Familia
        public ActionResult Index()
        {
            List<Class2> lst;
            using (PruebaTEntities db = new PruebaTEntities())
            {
                lst = (from e in db.IN05
                       select new Class2
                       {
                           IDFamilia = e.IDFamilia,
                           NombreFamilia = e.NombreFamilia,
                           UsuarioIngreso = e.UsuarioIngreso,
                           Estado = (int)e.Estado,
                           

                       }).ToList();
            }

            return View(lst);
        }
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(FamiliaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (PruebaTEntities db = new PruebaTEntities())
                    {
                        var oTabla = new IN05();
                        oTabla.NombreFamilia = model.NombreFamilia;
                        oTabla.UsuarioIngreso = model.UsuarioIngreso;
                        oTabla.Estado = model.Estado;

                        db.IN05.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("~/Familia/");
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