using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Step_8_PawTracks.Controllers
{
    public class ActivitiesController 
        : Controller
    {
      
        // CREATE
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.Activities a)
        {
            return View();
        }

        // READ
        public IActionResult Details(int id)
        {
            Models.Activities a = new Models.Activities();
            a.id = 1;
            a.dogid = 1;
            a.locationid = 1;
            a.date = 08042021;
            a.startTime = 1200;
            a.endTime = 1500;
            a.duration = 3;
            a.weather = "sunny";
            a.distance = 6.0f;
            a.notes = "Perfect day";

            return View(a);
        }

        // UPDATE
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Models.Activities a = new Models.Activities();
            a.id = 1;
            a.dogid = 1;
            a.locationid = 1;
            a.date = 08042021;
            a.startTime = 1200;
            a.endTime = 1500;
            a.duration = 3;
            a.weather = "sunny";
            a.distance = 6.0f;
            a.notes = "Perfect day";

            return View(a);
        }

        [HttpPost]
        public IActionResult Edit(Models.Activities a)
        {

            return View();
        }


        // DELETE
    }
}
