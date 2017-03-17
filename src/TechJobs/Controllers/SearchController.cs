﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        [Route("Search/Results")]        
        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Dictionary<string, string>> results;

            if (searchTerm is null)
            {
                searchTerm = "";
            }
            

            if (searchType == "all")
            {
                results = JobData.FindByValue(searchTerm);
            }
            else
            {
                results = JobData.FindByColumnAndValue(searchType, searchTerm);
            }

            
            ViewBag.jobs = results;
            ViewBag.columns = ListController.columnChoices;
            return View("~/Views/Search/Index.cshtml");

            //return Content("SearchType: " + searchType + " " + searchTerm);
            //return Content("You Found Me!");
        }
    }
}
