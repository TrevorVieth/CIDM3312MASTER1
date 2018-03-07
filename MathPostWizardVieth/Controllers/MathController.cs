using System;
using Microsoft.AspNetCore.Mvc;

namespace MathPostWizardVieth.Controllers

{
    public class MathPostWizardVieth : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Input()
        {
            return View();
        }
    }
}