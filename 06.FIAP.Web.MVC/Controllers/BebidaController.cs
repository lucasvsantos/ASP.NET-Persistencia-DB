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

        [HttpPost]
        public ActionResult Atualizar(Bebida bebida)
        {
            //Atualiza o banco de dados
            _context.Entry(bebida).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Bebida atualizada!";
            //Redirecionar
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            //Busca a bebida no DB
            var bebida = _context.Bebidas.Find(id);
            //Retorna a view com o objeto bebida
            return View(bebida);
        }

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
            TempData["msg"] = "Bebida cadastrada!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Recupera todas as bebidas e envia para a tela
            return View(_context.Bebidas.ToList());
        }
    }
}