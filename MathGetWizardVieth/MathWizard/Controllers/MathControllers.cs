using Microsoft.AspNetCore.Mvc;
using System;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(string left, string right){

            double leftop = Convert.ToDouble(left);
            double rightop = Convert.ToDouble(right);
            double sum = leftop + rightop;

            ViewData["Message"] = $"{left} plus {right} equals {sum}";

            return View();
        }
//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Subtract(string left, string right){

            double leftop = Convert.ToDouble(left);
            double rightop = Convert.ToDouble(right);
            double sum = leftop - rightop;
            
            ViewData["Message"] = $"{left} minus {right} equals {sum}";
            
            return View();
        }
//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Multiply(string left, string right){

            double leftop = Convert.ToDouble(left);
            double rightop = Convert.ToDouble(right);
            double sum = leftop * rightop;
            
            ViewData["Message"] = $"{left} multiplied by {right} equals {sum}";
            
            return View();
        }
//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Divide(string left, string right){

            double leftop = Convert.ToDouble(left);
            double rightop = Convert.ToDouble(right);
            double sum = leftop / rightop;

            if(rightop == 0)
            {
                //string path = @"C:\Temp\files";
                ViewData["Message"] = @"You can't divide by zero";
            }else{
                ViewData["Message"] = $"{left} divided by {right} equals {sum}";
            }
            
            return View();
        }
//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Modulus(string left, string right){

            double leftop = Convert.ToDouble(left);
            double rightop = Convert.ToDouble(right);
            double sum = leftop % rightop;
            
            ViewData["Message"] = $"{left} Modulus {right} equals {sum}";
            
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    
    }
}