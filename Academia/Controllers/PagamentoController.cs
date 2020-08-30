using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class PagamentoController : Controller
    {
        private academiaEntities db = new academiaEntities();
        // GET: Pagamento
        public ActionResult Index(string searchString)
        {
            var pagamento = from s in db.Pagamentoes
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                pagamento = pagamento.Where(s => s.Matricula.ToString().Contains(searchString) || s.PagamentoId.ToString().Contains(searchString) || s.Vencimento.ToString().Contains(searchString)
                                       || s.DataPagamento.ToString().Contains(searchString) );
            }

            return View(pagamento.ToList());
        }

        public ActionResult RelatorioInadimplencia(string searchString)
        {
            var pagamento = from s in db.Pagamentoes
                            select s;

           
                pagamento = pagamento.Where(s => s.DataPagamento.Value == null);

 

            return View(pagamento.ToList());
        }
        // GET: Pagamento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pagamento/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Pagamento/Create
        [HttpPost]
        public ActionResult Criar(Pagamento pagamento)
        {
            try
            {
                // TODO: Add insert logic here

                Pagamento PagamentoNovo = new Pagamento() ;
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    db.Pagamentoes.Add(pagamento);
                    db.SaveChanges();
               
                     PagamentoNovo.Matricula = pagamento.Matricula;
                     PagamentoNovo.Vencimento= pagamento.Vencimento.AddDays(30);
                     db.Pagamentoes.Add(PagamentoNovo);
                     db.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(pagamento);
            }
            catch
            {
                return View();
            }
        }

        // GET: Pagamento/Edit/5
        public ActionResult Editar(long id)
        {
            Pagamento pagamento = db.Pagamentoes.Find(id);
            return View(pagamento);
        }

        // POST: Pagamento/Edit/5
        [HttpPost]
        public ActionResult Editar(Pagamento pagamento)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    db.Entry(pagamento).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(pagamento);
            }
            catch
            {
                return View();
            }
        }

        // GET: Pagamento/Delete/5
        public string Excluir(long id)
        {
            try
            {
                Pagamento pagamento = db.Pagamentoes.Find(id);
                db.Pagamentoes.Remove(pagamento);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }

        // POST: Pagamento/Delete/5
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
