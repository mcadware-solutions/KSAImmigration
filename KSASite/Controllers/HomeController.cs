using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KSASite.Models;

namespace KSASite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult AgriFoodImmigrationPilot()
        {

            return View();
        }
        public IActionResult AtlanticImmigrationPilot()
        {

            return View();
        }
        public IActionResult CanadianExperienceClass()
        {

            return View();
        }
        public IActionResult Caregiver()
        {

            return View();
        }
        public IActionResult ExpressEntry()
        {
            return View();
        }
        public IActionResult FamilySponsorship()
        {
            return View();
        }
        public IActionResult FederalSkilledWorkers()
        {
            return View();
        }
        public IActionResult FederalSkillTradesClass()
        {
            return View();
        }
        public IActionResult PermanentResident()
        {
            return View();
        }
        public IActionResult ProvincialNomineePrograms()
        {
            return View();
        }
        public IActionResult RuralNorthernImmigrationPilot()
        {
            return View();
        }
        public IActionResult SelfEmployed()
        {
            return View();
        }
        public IActionResult StartUpVisa()
        {
            return View();
        }
        public IActionResult StudyPermit()
        {
            return View();
        }
        public IActionResult SuperVisa()
        {
            return View();
        }
        public IActionResult TemporaryResident()
        {
            return View();
        }
        public IActionResult Visit()
        {
            return View();
        }
        public IActionResult WorkPermit()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
