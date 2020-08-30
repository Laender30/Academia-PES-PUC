using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ClienteController : Controller
    {
        private academiaEntities db = new academiaEntities();
        // GET: Cliente
        public ActionResult Index(string searchString)
        {
            var usuario = from s in db.Usuarios
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                usuario = usuario.Where(s => s.Matricula.ToString().Contains(searchString) || s.Nome.Contains(searchString) || s.Telefone.Contains(searchString)
                                       || s.Email.Contains(searchString) || s.CPF.Contains(searchString));
            }

            return View(usuario.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Criar(Usuario usuario)
        {
            string TipoUsuario = "A";
            usuario.TipoUsuario = TipoUsuario;
            usuario.Ativo = true;
                    // TODO: Add insert logic here

                    if (ModelState.IsValid)
                    {
                        db.Usuarios.Add(usuario);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }

                    return View(usuario);
           
            }

        // GET: Cliente/Edit/5
        public ActionResult Editar(long id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            return View(usuario);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    db.Entry(usuario).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public string Excluir(long id)
        {
            try
            {
                Usuario usuario = db.Usuarios.Find(id);
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Excluir(int id, FormCollection collection)
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
