using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_CURD_Operation.Models;
using System.Data.Entity;

namespace Mvc_CURD_Operation.Controllers
{
    public class HomeController : Controller
    {
        ServicesContext db = new ServicesContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.emp.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid == true)
            {
                db.emp.Add(e);
             int a= db.SaveChanges();
                if(a>0)
                {
                    ViewBag.CreateMessage = ("<script>alert('Data Saved')</script>");
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.CreateMessage = ("<script>alert('Data Not Saved')</script>");
                }
            }
             return View();
          }

        public ActionResult Edit(int id)
        {
            var row = db.emp.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            db.Entry(e).State = EntityState.Modified;
            int a=db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = ("<script>alert('Data Saved')</script>");
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.UpdateMessage = ("<script>alert('Data Not modified')</script>");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row = db.emp.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            db.Entry(e).State = EntityState.Deleted;
           int a= db.SaveChanges();
            if (a > 0)
            {
                ViewBag.DeleteMessage = ("<script>alert('Data Delted')</script>");
                ModelState.Clear();
               return RedirectToAction("Index");
            }
            else
            {
                ViewBag.DeleteMessage = ("<script>alert('Data Not Deleted')</script>");
            }
            return View();
          
        }
    }
}