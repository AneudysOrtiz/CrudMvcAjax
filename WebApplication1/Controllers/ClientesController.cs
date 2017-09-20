using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(string nombre, string apellido, string correo)
        {
            GeneralContext db = new GeneralContext();
            Clientes cliente = new Clientes();
            cliente.nombre = nombre;
            cliente.apellido = apellido;
            cliente.correo = correo;
            db.Clientes.Add(cliente);
            db.SaveChanges();

            return PartialView("Lista",db.Clientes.ToList());
        }


        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            GeneralContext db = new GeneralContext();
            var cliente = db.Clientes.ToList().Find(x => x.idCliente == id);

            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }


            return PartialView("Lista", db.Clientes.ToList());
        }



    }
}