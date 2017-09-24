using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain;
using Project.Models;

namespace Project.Controllers
{
    public class NegociosController : Controller
    {
        private DataContextLocal db = new DataContextLocal();

        // GET: Negocios
        public async Task<ActionResult> Index()
        {
            var negocios = db.Negocios.Include(n => n.Categoria);
            return View(await negocios.ToListAsync());
        }

        // GET: Negocios/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Negocios negocios = await db.Negocios.FindAsync(id);
            if (negocios == null)
            {
                return HttpNotFound();
            }
            return View(negocios);
        }

        // GET: Negocios/Create
        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "nombreCategoria");
            return View();
        }

        // POST: Negocios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idNegocio,nombreNegocio,Direccion,Pais,Ciudad,Telefono,Telefono2,Logo,horarioAtencion,Descripcion,Online,idCategoria")] Negocios negocios)
        {
            if (ModelState.IsValid)
            {
                db.Negocios.Add(negocios);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "nombreCategoria", negocios.idCategoria);
            return View(negocios);
        }

        // GET: Negocios/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Negocios negocios = await db.Negocios.FindAsync(id);
            if (negocios == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "nombreCategoria", negocios.idCategoria);
            return View(negocios);
        }

        // POST: Negocios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idNegocio,nombreNegocio,Direccion,Pais,Ciudad,Telefono,Telefono2,Logo,horarioAtencion,Descripcion,Online,idCategoria")] Negocios negocios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(negocios).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "nombreCategoria", negocios.idCategoria);
            return View(negocios);
        }

        // GET: Negocios/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Negocios negocios = await db.Negocios.FindAsync(id);
            if (negocios == null)
            {
                return HttpNotFound();
            }
            return View(negocios);
        }

        // POST: Negocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Negocios negocios = await db.Negocios.FindAsync(id);
            db.Negocios.Remove(negocios);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
