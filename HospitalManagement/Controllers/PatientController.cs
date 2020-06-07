using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Add()
        {
            return View("PatientAdd"); 
        }

        public IActionResult Submit()
        {
            // return Content("You Had Submitted " +PatientName+ " he has Problem " + PatientProblem);
            string name = Request.Form["PatientName"].ToString();
            string problem = Request.Form["PatientProblem"].ToString();
            //return Content("Patient Name is "+name);
            return Content("You Had Submitted " + name + " he has Problem " + problem);
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}