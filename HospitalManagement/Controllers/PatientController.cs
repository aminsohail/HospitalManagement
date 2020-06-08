using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    public class PatientController : Controller
    {
        static List<PatientModel> patients = new List<PatientModel>();
        public IActionResult Add()
        {
            return View("PatientAdd", patients); 
        }

        public IActionResult Submit(PatientModel patientObj)
        {
            // string name = Request.Form["PatientName"].ToString();
            //string problem = Request.Form["PatientProblem"].ToString();
            //return Content("Patient Name is "+name);
            // return Content("You Had Submitted " + name + " he has Problem " + problem);
            //return Content("You Had Submitted " + obj.name + " he has Problem " + obj.problemDescription);

            patients.Add(patientObj); //in c# Add is used insted of push like in JS
            return View("PatientAdd", patients);
        }

        //public IActionResult ViewPatients()
        //{
          //  return View("DisplayPatients", patients);
       // }

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