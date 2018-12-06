using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class CharactersController : Controller
    {

        [Route("")]
        [Route("/characters/index")]
        public IActionResult Index()
        {
            return Content("Tjeeena");
            //return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CharactersCreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            return RedirectToAction(nameof(Index));
        }
    }
}