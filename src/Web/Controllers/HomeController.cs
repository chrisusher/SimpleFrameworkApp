using System;
using System.Web.Mvc;
using SimpleFrameworkApp.Services;

namespace SimpleFrameworkApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseService _database;

        public HomeController()
        {
            _database = new DatabaseService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var versionHistory = _database.GetVersionHistory();
            ViewBag.Message = $"Your application description page.{Environment.NewLine}" +
                              $"Running : '{versionHistory.ReleaseName}'...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}