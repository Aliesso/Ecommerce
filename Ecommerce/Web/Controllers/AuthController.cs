using DataAccess;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<K102User> _userManager;
        private readonly SignInManager<K102User> _signInManager;
        private readonly ApplicationDbContext _context;

        public AuthController(UserManager<K102User> userManager, SignInManager<K102User> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            K102User appUser = new K102User()
            {
                UserName = registerVM.Email,
                Email = registerVM.Email,
                Firstname=registerVM.Firstname,
                Lastname=registerVM.Lastname
            };
            IdentityResult result = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (result.Succeeded)
            {
                IdentityResult res = await _userManager.AddToRoleAsync(appUser, "User");              
                    return RedirectToAction("Login");                  
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerVM);
            }       
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            K102User appUser = await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser==null)
            {
                ModelState.AddModelError("", "Email yanlışdır!");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await
                _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RememberMe, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifrə yanlışdır!");
                return View(loginVM);
            }


            return RedirectToAction("Index","Home");
        }
    }
}
