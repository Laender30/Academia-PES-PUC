using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class AvaliacaoController : Controller
    {
        private academiaEntities db =new academiaEntities();
        // GET: Avaliacao

        /*public ActionResult Index()
        {
            var avaliacao = db.Avaliacaos.ToList();
            return View(avaliacao);
        }*/

        public ViewResult Index( string searchString)
        {
            var avaliacao = from s in db.Avaliacaos
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                avaliacao = avaliacao.Where(s => s.Anamnese.Contains(searchString) ||s.DobrasCutaneas.Contains(searchString) || s.Ergometrico.Contains(searchString)
                                       || s.DataAgendamento.ToString().Contains(searchString) || s.DataRealizacao.ToString().Contains(searchString));
            }

            return View(avaliacao.ToList());
        }

        // GET: Avaliacao/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: Avaliacao/Create
        public ActionResult criar()
        {
            return View();
        }

        // POST: Avaliacao/Create
        [HttpPost]
        public ActionResult criar(Avaliacao avaliacao)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    db.Avaliacaos.Add(avaliacao);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(avaliacao);
            }
            catch
            {
                return View();
            }
        }

        // GET: Avaliacao/Edit/5
        public ActionResult Editar(long id)
        {
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            return View(avaliacao);
        }

        // POST: Avaliacao/Edit/5
        [HttpPost]
        public ActionResult Editar(Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avaliacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(avaliacao);

        }
        [HttpPost]
     
        public string Excluir(long id)
        {
            try
            {
                Avaliacao avaliacao = db.Avaliacaos.Find(id);
                db.Avaliacaos.Remove(avaliacao);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }

        // POST: Avaliacao/Delete/5
    
  
    }
}
