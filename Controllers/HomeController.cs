using HangNguyenAPTISOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HangNguyenAPTISOnline.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Posts()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult CourseDetail()
        {
            return View();
        }

        public IActionResult Lesson()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            return View();
        }

        public IActionResult Profile()
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
