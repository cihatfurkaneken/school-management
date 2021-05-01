using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebObs.MVC.Identity;
using WebObs.MVC.Models.Security;

namespace WebObs.MVC.Controllers
{
    
   
    public class SecurityController : Controller
    {
        private UserManager<AppIdentityUser> _userManager;
        private RoleManager<AppIdentityRole> _roleManager;
        private SignInManager<AppIdentityUser> _signInManager;
        private IConfiguration _configuration;

        public SecurityController(UserManager<AppIdentityUser> userManager, RoleManager<AppIdentityRole> roleManager, SignInManager<AppIdentityUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnUrl = "")
        {
            if (ModelState.IsValid)
            {                
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                if (user != null)
                {                    
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, true);
                    if (result.Succeeded)
                    {
                        if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {                           
                            return Redirect(returnUrl);  //Başka sayfadan logine yönlendirdiyse giriş yapınca geri o sayfaya yolluyor.
                        }
                        else 
                        {
                            
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    ModelState.AddModelError(String.Empty, "Giris Basarisiz!");
                    return View(loginViewModel);
                }
                return View(loginViewModel);
            }
            return View(loginViewModel);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new AppIdentityUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.UserName
                };
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {             
                    var projectUrl = _configuration.GetSection("ProjectSettings").GetSection("ProjectUrl").Value;                  
                    return RedirectToAction("Login", "Security");

                }
                return View(registerViewModel);
            }
            return View(registerViewModel);
        }




    }
}
