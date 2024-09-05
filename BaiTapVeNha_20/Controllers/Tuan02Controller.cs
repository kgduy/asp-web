using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha_20.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hoten = "Phùng Khánh Duy";
            ViewBag.MSSV = "1822041439";
            ViewData["Nam"] = "2004";
            return View();
        }
    }
}
