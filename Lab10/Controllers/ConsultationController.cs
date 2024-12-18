using Microsoft.AspNetCore.Mvc;
using Lab10.Models; // Перевірте, що імпортована модель

namespace Lab10.Controllers
{
    public class ConsultationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ConsultationFormModel model)
        {
            if (ModelState.IsValid)
            {
                // Обробка форми
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
