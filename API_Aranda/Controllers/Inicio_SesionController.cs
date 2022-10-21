using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using API_Aranda.Models;

namespace API_Aranda.Controllers
{
    public class Inicio_SesionController : Controller
    {
        // GET: Inicio_Sesion
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();

        }

        // GET: Inicio_Sesion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        

        // POST: Modifica/Create
        //Este método conecta con la API pero para ello primero Serializa la solicitud en un Json
        [HttpPost]
        public ActionResult Create(Variables Inicio_sesion)
        {
            try
            {
                //instanciamos los dos modelos para tener acceso local
                Conexion_Api coman = new Conexion_Api();
                Variables variables = new Variables();

                //parametro de la API que vamos a utilizar del proyecto Webservices
               // string direccion = "http://preventacr.arandasoft.com/ASDKAPI/userRest.svc/login";
                string direccion = "http://preventacr.arandasoft.com/ASDKAPI//api/v8.6/user/login";
            
                string mensaje;
                //le mandamos el paquete a serializar
                

                mensaje = coman.Iniciar_Sesion<Variables>(direccion, Inicio_sesion, "POST");

                //este mensaje proviene de la consulta realizada a la base de datos
                ViewBag.Message = mensaje;
                //se mantiene en esta vista
                return View("Index");
            }
            catch
            {
                return View();
            }
        }





        // GET: Inicio_Sesion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inicio_Sesion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inicio_Sesion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inicio_Sesion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
