using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class HomeController : TechJobsController
    {
        public IActionResult Index()
        {
                       
            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
