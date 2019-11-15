using JsonConfig;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AssembliesController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // GET: Assemblies
        public JsonResult ApplicationsList()
        {
            DataClasses1DataContext conn = new DataClasses1DataContext();
            var listApplications = conn.Tab_Applications
                .Select(a => new { a.Nombre , a.Descripcion, a.Estado, FechaActualizacion= a.FechaActualizacion.ToString(), a.Id });

            return Json(listApplications, JsonRequestBehavior.AllowGet);

        }
    }
}