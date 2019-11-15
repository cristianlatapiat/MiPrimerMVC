using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SeccionController : Controller
    {
        // GET: Seccion
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Tabla()
        {
            return View();
        }
        public ActionResult ComboBox()
        {
            return View();
        }
        public ActionResult TablaJS()
        {
            return View();
        }

        public JsonResult ListaPersonas()
        {
            List<Persona> list = new List<Persona> {
                new Persona(){ ApellidoPaterno = "Muñoz", Idpersona =1,Nombre="Cristian" },
                new Persona(){ ApellidoPaterno = "Muñoz", Idpersona =2,Nombre="Magdalena" },
                new Persona(){ ApellidoPaterno = "Muñoz", Idpersona =3,Nombre="Javiera" },
            };

            return  Json(list,JsonRequestBehavior.AllowGet);
            


        }

    }
}