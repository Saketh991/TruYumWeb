﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TruYumWeb.Models;

namespace TruYumWeb.Controllers
{
    public class MenuItemsController : Controller
    {
        private TruYumContext db = new TruYumContext();

        // GET: MenuItems
        public ActionResult Index()
        {
            var menuItems = db.MenuItems.Include(m => m.Category);
            return View(menuItems.ToList());
        }

        // GET: MenuItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItems menuItems = db.MenuItems.Find(id);
            if (menuItems == null)
            {
                return HttpNotFound();
            }
            return View(menuItems);
        }

        // GET: MenuItems/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: MenuItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Active,DateOfLaunch,CategoryId,FreeDelivery")] MenuItems menuItems)
        {
            if (ModelState.IsValid)
            {
                db.MenuItems.Add(menuItems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", menuItems.CategoryId);
            return View(menuItems);
        }

        // GET: MenuItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItems menuItems = db.MenuItems.Find(id);
            if (menuItems == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", menuItems.CategoryId);
            return View(menuItems);
        }

        // POST: MenuItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Active,DateOfLaunch,CategoryId,FreeDelivery")] MenuItems menuItems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuItems).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", menuItems.CategoryId);
            return View(menuItems);
        }

        // GET: MenuItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuItems menuItems = db.MenuItems.Find(id);
            if (menuItems == null)
            {
                return HttpNotFound();
            }
            return View(menuItems);
        }

        // POST: MenuItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuItems menuItems = db.MenuItems.Find(id);
            db.MenuItems.Remove(menuItems);
            db.SaveChanges();
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
