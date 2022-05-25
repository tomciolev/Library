using Library.Models;
using Library.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Author
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Author());
        }

        [HttpPost]
        public ActionResult Create(Author author)
        {
            if(ModelState.IsValid)
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    db.Authors.Add(author);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(new Author());
        }

        [HttpGet]
        public ActionResult ViewAll()
        {
            List<Author> authors = new List<Author>();
            using (DatabaseContext db = new DatabaseContext())
                authors = db.Authors.ToList();
            return View(authors);
        }

        public ActionResult View(int id)
        {
            Author author;
            using(DatabaseContext db = new DatabaseContext())
                author = db.Authors.FirstOrDefault(x => x.AuthorId == id);
            return View(author);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Author author;
            using (DatabaseContext db = new DatabaseContext())
                author = db.Authors.FirstOrDefault(x => x.AuthorId == id);
            return View(author);
        }
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            if (!ModelState.IsValid)
                return View(author);
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(author).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("ViewAll");
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Author author;
            using(DatabaseContext db = new DatabaseContext())
            {
                author = db.Authors.FirstOrDefault(x => x.AuthorId == id);
            }
            return View(author);
        }
        //ActionName is useful if you have two Actions with the same signature that should have the same url
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            Author author;
            using (DatabaseContext db = new DatabaseContext())
            {
                author = db.Authors.FirstOrDefault(x => x.AuthorId == id);
                author = db.Authors.Remove(author);
                db.SaveChanges();
            }
            return RedirectToAction("ViewAll");
        }
        
    }
}