using System.Web.Mvc;

namespace TaskPlanner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult YourTasks()
        {
            ViewBag.Message = "This page lets you see your tasks.";

            return View();
        }
    }
}