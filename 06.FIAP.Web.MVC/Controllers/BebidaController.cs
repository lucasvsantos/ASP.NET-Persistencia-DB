using _06.FIAP.Web.MVC.Models;
using _06.FIAP.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06.FIAP.Web.MVC.Controllers
{
    public class BebidaController : Controller
    {
        private BotecoContext _context = new BotecoContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Bebida bebida)
        {
            _context.Bebidas.Add(bebida);
            _context.SaveChanges();
            return View();
        }
    }
}