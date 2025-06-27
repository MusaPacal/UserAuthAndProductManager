using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
          
            if (ModelState.IsValid)
            {
                var result=await _signInManager.PasswordSignInAsync(p.Usename, p.Password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Product");
                }
                ModelState.AddModelError(string.Empty, "Hatalı Kullanıcı Adı veya Şifre.");
            }
             return View(p);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
