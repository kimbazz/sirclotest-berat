using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Berat.Web.Models;
using DataTables.AspNet.Core;
using System;
using Berat.Web.Repository;
using DataTables.AspNet.AspNetCore;

namespace Berat.Web.Controllers
{
    public class HomeController : Controller
    {
        HomeRepository _repo;

        public HomeController()
        {
            _repo = new HomeRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTableAjaxHandler(IDataTablesRequest request)
        {
            try
            {
                DataTablesJsonResult model = _repo.GetAllBerat(request);
                return model;
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public IActionResult Create()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Berat param)
        {
            _repo.SaveBerat(param);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            Models.Berat model = _repo.GetBeratById(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Models.Berat param)
        {
            _repo.UpdateBerat(param);
            return RedirectToAction("Index");
        }

        public IActionResult Detail()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
