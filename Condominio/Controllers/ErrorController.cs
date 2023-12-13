﻿using Condominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Condominio.Controllers
{
	public class ErrorController : Controller
	{
		// GET: ErrorController
		public ActionResult Index()
		{
			ViewBag.Error = new ErrorHandler()
			{
				Title = "You must login to access this resource",
				ErrorMessage = "Session is inactive",
				ActionMessage = "Go to login",
				Path = "/Login"
			};

			return View("ErrorHandler");			
		}

		// GET: ErrorController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ErrorController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: ErrorController/Create
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

		// GET: ErrorController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: ErrorController/Edit/5
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

		// GET: ErrorController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: ErrorController/Delete/5
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
