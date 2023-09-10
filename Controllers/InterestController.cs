using Microsoft.AspNetCore.Mvc;
using TinhLaiSuatWeb.Models;

namespace TinhLaiSuatWeb.Controllers
{
    public class InterestController : Controller
    {
        [HttpGet]
        public IActionResult InterestCal()
        {
            var model = new InterestModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult InterestCal(InterestModel input)
        {
            var result = new InterestModel((int)input.Money, (int)input.InterestRate, (int)input.Time);
            return View(result);
        }
    }
}
