﻿using LibApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibApp.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET: BooksController/Random
        public IActionResult Random()
        {
            var firstBook = new Book() { Author = "Random author", Title = "Random title" };
            return View(firstBook);
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }



        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
