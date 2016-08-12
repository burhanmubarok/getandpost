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
        public IActionResult SubmitGet(string field, string fieldOther)
        {
            return Json(new {message = "hmmmm.. looks good"});
        }

        [HttpPost]
        public IActionResult SubmitPost(FormFields form)
        {
            return Json(JsonConvert.SerializeObject(form));
        }
    }
}