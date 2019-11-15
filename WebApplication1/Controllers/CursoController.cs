using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public string mensaje()
        {
            return "Bienvenido";
        }
        public string saludos(string nombre, string apellido)
        {
            return $"Hola como estas {nombre} {apellido}";
        }

        public JsonResult CursosList()
        {
            SistemaMatriculaEntities db = new SistemaMatriculaEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
            var list = db.Curso.Where(c => c.BHABILITADO.Value.Equals(1)).Select(c => new { c.IIDCURSO, c.NOMBRE, c.DESCRIPCION }).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);


        }
    }
}