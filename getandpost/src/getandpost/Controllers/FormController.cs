using getandpost.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace getandpost.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubmitGet(string field, string fieldOther, FormFields form)
        {
            return Json(new {message = "hmmmm.. looks good", model = form});
        }

        [HttpPost]
        public IActionResult SubmitPost(FormFields form)
        {
            return Json(new {model = form});
        }
    }
}